using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyStatus : MonoBehaviour {

	public int enemyHP = 50; //敵のHP
	public int eneAttack = 10; //敵の攻撃力

	[SerializeField]
	private string scenestr = "GameClear"; //敵を倒した時の遷移先のシーン名

	[SerializeField]
	private MenuSwitch menu;
	[SerializeField]
	private playerStatus playerStatus;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		if (menu.playerTurn == false)
		{
			playerStatus.damage(eneAttack);
		}
	}

	public void enedamage (int attackPoint)
	{
		enemyHP -= attackPoint;
		//Debug.Log(enemyHP);

		if (enemyHP <= 0)
		{
			SceneManager.LoadScene(scenestr);
		}
	}
}
