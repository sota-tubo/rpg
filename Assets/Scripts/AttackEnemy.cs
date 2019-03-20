using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackEnemy : MonoBehaviour {

	public bool attack { get; set; } //攻撃が選択された時
	//public magicCount magiccount { get; set; } //どの魔法が使われたのかをチェック
	public string magickind { get; set; } //使う魔法・アイテムの種類
    
	[SerializeField]
	private playerStatus playerstat;
	[SerializeField]
	private messagetext mess;
	[SerializeField]
	private Attack playerattack;
	[SerializeField]
	private Magic magic;

	private enemyStatus enemyStatus;
	private magicEffect magiceffect;

	private Button enemy;

	// Use this for initialization
	void Start () {
		attack = false;
		enemyStatus = GetComponent<enemyStatus>();
		enemy = GetComponent<Button>();
		magiceffect = GetComponent<magicEffect>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		//こうげきが選択された時
		if (attack == true)
		{
			enemy.enabled = true;
		}
        //こうげきの選択がキャンセルされた時もしくは攻撃した後
		else if (attack == false)
		{
			enemy.enabled = false;
		}
        //右クリックした時
		if (Input.GetMouseButtonDown(1))
		{
			mess.message.enabled = false;
		}
	}
    //攻撃時に敵をクリックした時。選択した敵にダメージ処理を行う
	public void EnemyClicked()
	{
		//たたかうを選択した時
		if (playerattack.attackselect == true)
		{
			attack = false;

			Debug.Log("Attack");
			enemyStatus.enedamage(playerstat.playerAttack, magickind);
		}
		//まほう(攻撃魔法)を選択した時
		else if (magic.magicselect == true)
		{
			attack = false;

			//magiccount.count--;

			Debug.Log(magickind);
			magiceffect.changeEffect(magickind);
			enemyStatus.enedamage(playerstat.magicAttack, magickind);
		}
		//まほう(回復魔法)を選択した時
		else if (playerattack.heal == true)
		{
			attack = false;

			//magiccount.count--;
			Debug.Log(magickind);
			enemyStatus.enedamage(-playerstat.magicHeal, magickind);
		}
		//アイテム(お金を選択した場合)
		else if (magickind == "Money")
		{
			if (GetComponent<gorotuki>())
			{
				enemyStatus.enedamage(50, magickind); //ごろつきの体力は50なので、
			}
			else
			{
				mess.setmessage("敵は興味がないようだ...");
				mess.message.enabled = true;
			}
		}

	}
}
