using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerStatus : MonoBehaviour {

	public int playerHP = 100; //プレイヤーの体力
	public int playerAttack = 20; //プレイヤーの攻撃力
	[SerializeField]
	private MenuSwitch menu;
	[SerializeField]
	private messagetext mess;

	private Text hpText;

	// Use this for initialization
	void Start () {
		hpText = GetComponent<Text>();
		hpText.text = playerHP.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		if (mess.enabled == true && Input.GetMouseButtonDown(0))
		{
			mess.enabled = false;
            menu.MS = true;
		}
	}

	public void damage(int damnum)
	{
		playerHP -= damnum;

		mess.setmessage("プレイヤーは" + damnum + "ポイントのダメージを受けた！！");
		mess.enabled = true;

		if (playerHP <= 0)
        {
            playerHP = 0;
        }

		hpText.text = playerHP.ToString();

		if (playerHP == 0)
		{
			SceneManager.LoadScene("GameOver");
		}

		menu.playerTurn = true;
	}
}
