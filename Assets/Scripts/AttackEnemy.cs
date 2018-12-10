using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackEnemy : MonoBehaviour {

	public bool attack { get; set; } //攻撃が選択された時

	[SerializeField]
	private MenuSwitch Switch;
	[SerializeField]
	private playerStatus playerstat;
	[SerializeField]
	private messagetext mess;
	[SerializeField]
	private Attack playerattack;
	[SerializeField]
	private Magic magic;

	private enemyStatus enemystat;

	private Button enemy;

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
    //攻撃時に敵をクリックした時
	public void EnemyClicked()
	{
		//たたかうを選択した時
		if (playerattack.attackselect == true)
		{
			attack = false;

            enemystat.enedamage(playerstat.playerAttack);

            mess.setmessage("敵に" + playerstat.playerAttack + "ポイントのダメージを与えた！");
			mess.message.enabled = true;

			playerattack.attackselect = false;
            Switch.MS = false;
		}
		//まほう(攻撃魔法)を選択した時
		else if (magic.magicselect == true)
		{
			attack = false;

			enemystat.enedamage(playerstat.magicAttack);

			mess.setmessage("敵に" + playerstat.magicAttack + "ポイントのダメージを与えた！");
			mess.message.enabled = true;

			magic.magicselect = false;
            Switch.MS = false;
		}
        
	}

}
