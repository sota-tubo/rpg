using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemyStatus : MonoBehaviour {
	//敵のステータス調整、敵・背景の切り替え、ダメージ処理をするためのスクリプト

	public int enemyHP = 50; //敵のHP(あくまでも初期HPなだけで上限ではない)
	public int eneAttack = 10; //敵の攻撃力
    
	public string scenestr = "GameClear"; //敵を倒した時の遷移先のシーン名
	public Sprite jii, jiismile, yuusya, myst, dark; //敵の絵の変更
	public Sprite backjii, backmyst; //背景の変更
    
	public MenuSwitch menu { get; private set; } //敵が攻撃する時のプレイヤーのメニュー表示の切り替え
	public Magic magic; //魔法が選択されたかどうかを確認するため
	public messagetext mess { get; private set; } //上部メッセージのテキスト変更
	[SerializeField]
	private Attack playerattack = null; //どのコマンドが選択されたのかを確認するため
	private enemyDamageEffect DamageEffect; //敵のダメージエフェクトを表示させるため
	private playerStatus playerstatus; //プレイヤーにダメージを与える時

	public FadeScript Fade { get; private set; } //フェードインさせるため
	private GameObject background; //背景のオブジェクト

	private int confuturn; //混乱をかけられて何ターン目か(学者を使用時)
	private string checktag = null; //何の特技が発動したかのタグチェック

	// Use this for initialization
	void Start () {
		menu = GameObject.Find("GameSystem").GetComponent<MenuSwitch>();
		playerstatus = GameObject.Find("PlayerHP").GetComponent<playerStatus>();
		mess = GameObject.Find("messageText").GetComponent<messagetext>();
		DamageEffect = GetComponent<enemyDamageEffect>();


		Fade = GameObject.Find("FadeSystem").GetComponent<FadeScript>();
		background = GameObject.Find("background");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		//敵のターンになった時
		if (!menu.playerTurn)
		{
			//混乱中の敵の行動
			if (checktag == "confuse" || confuturn > 0)
			{
				confuturn++;
				//(掛けたターンを含め)3ターン経ったら混乱解除
				if (confuturn == 3)
				{
					mess.setmessage("敵の混乱が解けた！");
					mess.message.enabled = true;

					confuturn = 0;
				}
				else
				{
					mess.setmessage("敵は混乱している！！");
					mess.message.enabled = true;
				}

				menu.playerTurn = true;
				playerattack.attackselect = true;
                magic.magicselect = true;
                menu.MS = true;
			}
			else
			{
				playerstatus.damage(eneAttack);
			}
		}
	}
    //敵のダメージ処理
	public void enedamage (int attackpoint, string magictag)
	{
		DamageEffect.effectOn();

        //学者のスキルを使用した時
		if (magictag == "confuse")
		{
			//闇の魔術師には効果がない
			if (GetComponent<dark>() != null)
			{
				mess.setmessage("効果がなかった！");
                mess.message.enabled = true;
			}
			else
			{
				mess.setmessage("敵は混乱した！");
				mess.message.enabled = true;

                //混乱を掛け直したらターンカウントリセット
				confuturn = 0;
				checktag = magictag;
			}
			return;
		}

        //敵のダメージ処理
        //敵がごろつきの場合
		if (GetComponent<gorotuki>() != null)
		{
			GetComponent<gorotuki>().damage(attackpoint, magictag);
		}
        //敵がおじいさんの場合
		else if (GetComponent<jii>() != null)
		{
			GetComponent<jii>().damage(attackpoint);
		}
        //敵が謎の魔術師の場合
		else if (GetComponent<myst>() != null)
		{
			GetComponent<myst>().damage(attackpoint, magictag);
		}
        //敵が闇の魔術師の場合
		else if (GetComponent<dark>() != null)
		{
			GetComponent<dark>().damage(attackpoint, magictag);
		}

        //敵の体力が0になった時
		if (enemyHP <= 0)
		{
			confuturn = 0;
			//SceneManager.LoadScene(scenestr);
            //お金を使って敵を倒した場合
			if (magictag == "Money")
			{
				mess.setmessage("敵を退けた！");
				mess.message.enabled = true;
			}
            //敵を倒した場合
			else
			{
				mess.setmessage("敵を倒した！！");
				mess.message.enabled = true;
			}

            //メニュー表示
            playerattack.attackselect = true;
			magic.magicselect = true;
			menu.MS = true;

            //フェードイン
			Fade.fade();

            //敵がおじいさんの場合画像切り替え
			if (GetComponent<Image>().sprite == jiismile)
			{
				StartCoroutine("smilespan");
			}
            //敵の画像切り替え
			else
			{
				ChangeEnemy();
			}

			mess.message.enabled = false;
		}
        //敵の体力が残っている場合メニュー非表示
		else
		{
            playerattack.attackselect = false;
			magic.magicselect = false;
			menu.MS = false;
		}
	}
    //敵の画像切り替え
    void ChangeEnemy()
	{
		//倒された敵がごろつきの場合
		if (gameObject.name == "gorotuki")
		{
			Destroy(GetComponent<gorotuki>());

			GetComponent<Image>().sprite = jii;
			background.GetComponent<Image>().sprite = backjii;
			gameObject.name = "jii";
			gameObject.AddComponent<jii>();

			enemyHP = 50;
            eneAttack = 0;
		}
        //倒された敵がおじいさんの場合
		else if (gameObject.name == "jii")
		{
			Destroy(GetComponent<jii>());

			GetComponent<Image>().sprite = myst;
			background.GetComponent<Image>().sprite = backmyst;
            gameObject.name = "myst";
			gameObject.AddComponent<myst>();

			enemyHP = 80;
            eneAttack = 20;
		}
        //倒された敵が謎の魔術師の場合
		else if (gameObject.name == "myst")
		{
			Destroy(GetComponent<myst>());

			GetComponent<Image>().sprite = dark;
            gameObject.name = "dark";
			gameObject.AddComponent<dark>();

			enemyHP = 100;
            eneAttack = 25;
		}
        //倒された敵が闇の魔術師の場合
		else
		{
			SceneManager.LoadScene(scenestr);
		}

		//menu.MS = true;
		//menu.playerTurn = true;
	}
    //おじいさんを救った場合の画像切り替え
	IEnumerator smilespan()
	{
		GameObject.Find("magicframe").SetActive(false);

		yield return new WaitForSeconds(1.0f);

		mess.message.enabled = false;

		Fade.fade();
		ChangeEnemy();
	}
}
