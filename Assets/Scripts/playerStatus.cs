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
	private MenuSwitch menu;
	[SerializeField]
	private messagetext mess;
    
	private Text hpText;
	private damageEffect effect;

	// Use this for initialization
	void Start () {
		hpText = GetComponent<Text>();
		hpText.text = playerHP.ToString();
		effect = GameObject.Find("playerEffect").GetComponent<damageEffect>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		/*
		if (mess.enabled == true && Input.GetMouseButtonDown(0))
		{
			mess.message.enabled = false;
		}
		*/
	}
    //プレイヤーのダメージ処理
	public void damage(int damnum)
	{
		playerHP -= damnum;

		if (playerHP <= 0)
        {
            playerHP = 0;
        }

		hpText.text = playerHP.ToString();

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

		if (playerHP >= playerMAXHP)
		{
			playerHP = playerMAXHP;
		}

		hpText.text = playerHP.ToString();

		mess.setmessage("プレイヤーは" + healnum + "ポイントのダメージを回復した！");
		mess.message.enabled = true;

        
	}
}
