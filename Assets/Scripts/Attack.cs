using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
	//どのコマンドを選択したのか判定する、敵を選択できるようにするためのスクリプト

	public bool attackselect { get; set; } //たたかうが選択されたかどうか
	public bool heal { get; set; } //回復のまほうを選択した時
	public bool skillselect { get; set; } //特技を選択した時
	public GameObject playerButton; //回復時のプレイヤーを表示するためのボタン

	[SerializeField]
	private AttackEnemy enemy; //敵を選択できるようにするため
	[SerializeField]
	private messagetext mess; //上部メッセージ内容を変更するため
	[SerializeField]
	private Magic magic; //攻撃魔法が選択されたかどうか
	//[SerializeField]
	//private enemyStatus eneStatus; //敵の体力を参照するため

	// Use this for initialization
	void Start () {
		attackselect = false;
		heal = false;
		skillselect = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		/*
		if(Input.GetMouseButtonDown(1) && attackselect && eneStatus.enemyHP > 0)
		{
			mess.message.enabled = false;
			attackselect = false;
			enemy.attack = false;
		}
		*/

		if (!enemy.attack)
		{
			playerButton.SetActive(false);
		}
	}
    //こうげき選択時
	public void attackSelected()
	{
		attackselect = true;
		magic.magicselect = false;

		mess.setmessage("どの敵を攻撃する？");
		mess.message.enabled = true;

		enemy.attack = true;
	}

    //攻撃魔法を選択時
	public void magicattackSelected()
	{
		mess.setmessage("どの敵を攻撃する？");
        mess.message.enabled = true;

        enemy.attack = true;
	}

    //回復選択時
	public void magicSelected()
	{
		heal = true;
		magic.magicselect = false;

		mess.setmessage("誰を回復する？");
		mess.message.enabled = true;

		playerButton.SetActive(true);

		enemy.attack = true;
	}

	//アイテム(お金を選択時)
	public void moneySelected()
	{
		mess.setmessage("どの敵にお金をあげる？");
		mess.message.enabled = true;

		enemy.attack = true;
	}

    //特技選択時
	public void skillSelected()
	{
		skillselect = true;

		mess.setmessage("どの敵に使う？");
        mess.message.enabled = true;

        enemy.attack = true;
	}
}
