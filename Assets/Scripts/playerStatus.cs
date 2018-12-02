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
		
	}

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
			SceneManager.LoadScene("GameOver");
		}

		menu.playerTurn = true;
		menu.MS = true;
	}

}
