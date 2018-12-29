using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemyStatus : MonoBehaviour {

	public int enemyHP = 50; //敵のHP
	public int eneAttack = 10; //敵の攻撃力

	[SerializeField]
	private string scenestr = "GameClear"; //敵を倒した時の遷移先のシーン名
	[SerializeField]
	private Sprite jii, jiismile, yuusya, myst, dark; //敵の絵の変更
	[SerializeField]
	private Sprite backjii, backmyst; //背景の変更

	[SerializeField]
	private MenuSwitch menu;
	[SerializeField]
	private playerStatus playerStatus;
	[SerializeField]
	private Magic magic;
	[SerializeField]
	private messagetext mess;
	[SerializeField]
	private Attack playerattack;

	private FadeScript Fade;
	private GameObject background;

	// Use this for initialization
	void Start () {
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
			playerStatus.damage(eneAttack);
		}
	}
    //敵のダメージ処理
	public void enedamage (int attackPoint)
	{
		if (gameObject.name == "gorotuki")
		{
			enemyHP -= attackPoint;
			if (attackPoint >= 0)
			{
				mess.setmessage("敵に" + attackPoint + "ポイントのダメージを与えた！");
                mess.message.enabled = true;
			}
			else
			{
				mess.setmessage("敵は" + -attackPoint + "ポイントのダメージを回復した！");
                mess.message.enabled = true;
			}
		}
		else if (gameObject.name == "jii")
		{
			if (attackPoint <= 0f)
			{
				GetComponent<Image>().sprite = jiismile;
				enemyHP -= enemyHP;
			}
			else
			{
				mess.setmessage("危ないっ！");
				mess.message.enabled = true;

				Fade.fade();
				GetComponent<Image>().sprite = yuusya;

				enemyHP = 1000;
				eneAttack = 10000;
			}
		}
		else if (gameObject.name == "myst")
		{
			enemyHP -= attackPoint;

			if (attackPoint >= 0)
            {
                mess.setmessage("敵に" + attackPoint + "ポイントのダメージを与えた！");
                mess.message.enabled = true;
            }
            else
            {
                mess.setmessage("敵は" + -attackPoint + "ポイントのダメージを回復した！");
                mess.message.enabled = true;
            }
		}
		else if (gameObject.name == "dark")
		{
			if (magic.magicselect == true)
			{
				enemyHP -= (int)(attackPoint / 2);

				mess.setmessage("敵に" + (int)(attackPoint / 2) + "ポイントのダメージを与えた！");
                mess.message.enabled = true;
			}
			else
			{
				enemyHP -= attackPoint;

				if (attackPoint >= 0)
                {
                    mess.setmessage("敵に" + attackPoint + "ポイントのダメージを与えた！");
                    mess.message.enabled = true;
                }
                else
                {
                    mess.setmessage("敵は" + -attackPoint + "ポイントのダメージを回復した！");
                    mess.message.enabled = true;
                }
			}
		}
		//Debug.Log(enemyHP);

		if (enemyHP <= 0)
		{
			//SceneManager.LoadScene(scenestr);
			mess.setmessage("敵を倒した！！");
            mess.message.enabled = true;

            playerattack.attackselect = false;
			magic.magicselect = false;

			Fade.fade();
            ChangeEnemy();

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
			GetComponent<Image>().sprite = jii;
			background.GetComponent<Image>().sprite = backjii;
			gameObject.name = "jii";

			enemyHP = 50;
            eneAttack = 10;
		}
		else if (gameObject.name == "jii")
		{
			GetComponent<Image>().sprite = myst;
			background.GetComponent<Image>().sprite = backmyst;
            gameObject.name = "myst";

			enemyHP = 80;
            eneAttack = 20;
		}
		else if (gameObject.name == "myst")
		{
			GetComponent<Image>().sprite = dark;
            gameObject.name = "dark";

			enemyHP = 100;
            eneAttack = 30;
		}
		else
		{
			SceneManager.LoadScene(scenestr);
		}

		//menu.MS = true;
		//menu.playerTurn = true;
	}
}
