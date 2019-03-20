using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemyStatus : MonoBehaviour {

	public int enemyHP = 50; //敵のHP
	public int eneAttack = 10; //敵の攻撃力
    
	public string scenestr = "GameClear"; //敵を倒した時の遷移先のシーン名
	public Sprite jii, jiismile, yuusya, myst, dark; //敵の絵の変更
	public Sprite backjii, backmyst; //背景の変更
    
	public MenuSwitch menu { get; private set; }
	private playerStatus playerstatus;
	public Magic magic;
	public messagetext mess { get; private set; }
	[SerializeField]
	private Attack playerattack;
	private enemyDamageEffect DamageEffect;

	public FadeScript Fade { get; private set; }
	private GameObject background;

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
		if (menu.playerTurn == false)
		{
			playerstatus.damage(eneAttack);
		}
	}
    //敵のダメージ処理
	public void enedamage (int attackpoint, string magictag)
	{
		DamageEffect.effectOn();

		if (GetComponent<gorotuki>() != null)
		{
			GetComponent<gorotuki>().damage(attackpoint, magictag);
		}
		else if (GetComponent<jii>() != null)
        {
            GetComponent<jii>().damage(attackpoint);
        }
		else if (GetComponent<myst>() != null)
        {
			GetComponent<myst>().damage(attackpoint, magictag);
        }
		else if (GetComponent<dark>() != null)
        {
			GetComponent<dark>().damage(attackpoint, magictag);
        }

		Debug.Log(enemyHP);

		if (enemyHP <= 0)
		{
			//SceneManager.LoadScene(scenestr);
			if (magictag == "Money")
			{
				mess.setmessage("敵を退けた！");
				mess.message.enabled = true;
			}
			else
			{
				mess.setmessage("敵を倒した！！");
				mess.message.enabled = true;
			}

            playerattack.attackselect = false;
			magic.magicselect = false;

			Fade.fade();

			if (GetComponent<Image>().sprite == jiismile)
			{
				StartCoroutine("smilespan");
			}
			else
			{
				ChangeEnemy();
			}

			mess.message.enabled = false;
		}
		else
		{
            playerattack.attackselect = false;
			magic.magicselect = false;
			menu.MS = false;
		}
	}

    void ChangeEnemy()
	{
		//敵切り替え時に自ターンにならずダメージを受けてしまう
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
		else if (gameObject.name == "myst")
		{
			Destroy(GetComponent<myst>());

			GetComponent<Image>().sprite = dark;
            gameObject.name = "dark";
			gameObject.AddComponent<dark>();

			enemyHP = 100;
            eneAttack = 25;
		}
		else
		{
			SceneManager.LoadScene(scenestr);
		}

		//menu.MS = true;
		//menu.playerTurn = true;
	}

	IEnumerator smilespan()
	{
		GameObject.Find("magicframe").SetActive(false);

		yield return new WaitForSeconds(1.0f);

		mess.message.enabled = false;

		Fade.fade();
		ChangeEnemy();
	}
}
