using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackEnemy : MonoBehaviour {
	//敵を選択した時に処理を行うスクリプト

	public bool attack { get; set; } //攻撃が選択された時
	//public magicCount magiccount { get; set; } //どの魔法が使われたのかをチェック
	public string magickind { get; set; } //使う魔法・アイテムの種類

	[SerializeField]
	private playerStatus playerstat; //プレイヤーの攻撃力、魔力、回復力を参照するため
	[SerializeField]
	private messagetext mess; //上部メッセージ内容を変更するため
	[SerializeField]
	private Attack playerattack; //どのコマンドが選択されたのかを確認するため
	[SerializeField]
	private Magic magic; //魔法が選択されたかどうかを確認するため

	private enemyStatus enemyStatus; //ダメージ処理を実行できるようにするため
	private magicEffect magiceffect; //魔法のエフェクトを実行できるようにする

	private Button enemy; //敵を選択できるようにするため

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
		if (attack)
		{
			enemy.enabled = true;
		}
        //こうげきの選択がキャンセルされた時もしくは攻撃した後
		else if (!attack)
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
		if (playerattack.attackselect)
		{
			attack = false;
            
			enemyStatus.enedamage(playerstat.playerAttack, magickind);
		}
		//まほう(攻撃魔法)を選択した時
		else if (magic.magicselect)
		{
			attack = false;

			//magiccount.count--;

			magiceffect.changeEffect(magickind);
			enemyStatus.enedamage(playerstat.magicAttack, magickind);
		}
		//まほう(回復魔法)を選択した時
		else if (playerattack.heal)
		{
			attack = false;

			//magiccount.count--;
			enemyStatus.enedamage(-playerstat.magicHeal, magickind);
		}
		//アイテム(お金を選択した場合)
		else if (magickind == "Money")
		{
			//ごろつきに使用した場合倒すことができる
			if (GetComponent<gorotuki>())
			{
				enemyStatus.enedamage(1000, magickind);
			}
			else
			{
				mess.setmessage("敵は興味がないようだ...");
				mess.message.enabled = true;
			}

			enemyStatus.enedamage(-playerstat.magicHeal, magickind);
		}
		//特技を選択した時
		else if (playerattack.skillselect)
		{
			attack = false;

			enemyStatus.enedamage(playerstat.magicAttack, magickind);
		}
	}
}
