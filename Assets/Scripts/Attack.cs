using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	public bool attackselect { get; set; } //たたかうが選択されたかどうか
	public bool heal { get; set; } //回復のまほうを選択した時
	public GameObject playerButton; //回復時のプレイヤーを表示するためのボタン

	[SerializeField]
	private AttackEnemy enemy;
	[SerializeField]
	private messagetext mess;
	[SerializeField]
	private Magic magic;
	[SerializeField]
	private enemyStatus eneStatus;

	// Use this for initialization
	void Start () {
		attackselect = false;
		heal = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		if(Input.GetMouseButtonDown(1) && attackselect == true && eneStatus.enemyHP > 0)
		{
			mess.message.enabled = false;
			attackselect = false;
			enemy.attack = false;
		}

		if (enemy.attack == false)
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
}
