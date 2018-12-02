﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackEnemy : MonoBehaviour {

	public bool attack { get; set; } //攻撃が選択された時

	[SerializeField]
	private MenuSwitch Switch;
	[SerializeField]
	private playerStatus playerstat;

	private enemyStatus enemystat;

	private Button enemy;
    //攻撃ボタンが押された時enemyのボタンをtrueにし、enemyが選択されたらmenuとenemyのボタンを消す

	// Use this for initialization
	void Start () {
		attack = false;
		enemystat = GetComponent<enemyStatus>();
		enemy = GetComponent<Button>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		if (attack == true)
		{
			enemy.enabled = true;
		}
		else if (attack == false)
		{
			enemy.enabled = false;
		}
	}

	public void EnemyClicked()
	{
		attack = false;

		enemystat.enedamage(playerstat.playerAttack);

		Switch.MS = false;
	}

}
