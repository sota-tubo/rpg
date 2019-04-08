using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour {
	//プレイヤーの回復処理を行うためのスクリプト

	[SerializeField]
	private playerStatus player = null; //プレイヤーの回復処理を行うため
	[SerializeField]
	private AttackEnemy at = null; //プレイヤーが回復を実行した時に他の行動をできないようにするため
	[SerializeField]
	private Magic magic = null;
	[SerializeField]
	private MenuSwitch menu = null; //魔法が選択されたかどうかを確認するため
	[SerializeField]
	private GameObject selectPlayer = null; //プレイヤーを選択できるようにする

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //かいふくをクリックした時
	public void clickHeal()
	{
		at.attack = false;

		player.heal(player.magicHeal);

		magic.magicselect = false;
		menu.MS = false;
		selectPlayer.SetActive(false);
	}
}
