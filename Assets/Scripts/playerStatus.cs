using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerStatus : MonoBehaviour {

	public int playerHP = 100; //プレイヤーの体力
	public int playerMAXHP { get; set; } //プレイヤーの最大体力
	public int playerAttack = 20; //プレイヤーの攻撃力
	public int magicAttack = 20; //プレイヤーの魔法攻撃力
	public int magicHeal = 40; //プレイヤーの魔法回復力
	[SerializeField]
	private MenuSwitch menu = null; //メニューの表示非表示
	[SerializeField]
	private messagetext mess = null; //上部のメッセージ制御
    
	private Text hpText; //プレイヤーの体力表示
	private damageEffect effect; //プレイヤーのダメージエフェクト表示

	// Use this for initialization
	void Start () {
		hpText = GetComponent<Text>();
		hpText.text = playerHP.ToString();
		effect = GameObject.Find("playerEffect").GetComponent<damageEffect>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //プレイヤーのダメージ処理
	public void damage(int damnum)
	{
		playerHP -= damnum;

        //プレイヤーの体力が0以下になった場合0にする
		if (playerHP <= 0)
        {
            playerHP = 0;
        }

        //現体力を表示
		hpText.text = playerHP.ToString();

        //プレイヤーの体力が0になったらゲームオーバーシーンへ遷移
		if (playerHP == 0)
		{
			mess.setmessage("プレイヤーはやられてしまった！！");
			mess.message.enabled = true;
			SceneManager.LoadScene("GameOver");
		}

		mess.setmessage("プレイヤーは" + damnum + "ポイントのダメージを受けた！！");
		mess.message.enabled = true;

		effect.playereffect();

		menu.playerTurn = true;
		menu.MS = true;
	}

    //プレイヤーの回復処理
	public void heal(int healnum)
	{
		Debug.Log("healing");
		playerHP += healnum;

        //体力の上限を超えたら上限の値にする
		if (playerHP >= playerMAXHP)
		{
			playerHP = playerMAXHP;
		}

		hpText.text = playerHP.ToString();

		mess.setmessage("プレイヤーは" + healnum + "ポイントのダメージを回復した！");
		mess.message.enabled = true;

        
	}
}
