using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jii : MonoBehaviour {
	//おじいさん(現段階で2番目の敵)のダメージ処理をするためのスクリプト

	private enemyStatus eneStatus; //敵の体力を参照
	private AttackEnemy attackEnemy; //タグでコマンドを判定

	private void Start()
	{
		eneStatus = GetComponent<enemyStatus>();
		attackEnemy = GetComponent<AttackEnemy>();
	}

	//ダメージを受けた時
	public void damage(int damagepoint)
    {
		//敵を回復した場合
		if (damagepoint <= 0f)
        {
			//コマンドのタグがお金以外の場合
			if (attackEnemy.magickind != "Money")
			{
				eneStatus.Fade.fade();
				GetComponent<Image>().sprite = eneStatus.jiismile;
				eneStatus.enemyHP = 0;
			}
        }
        //敵を攻撃した場合
        else
        {
			eneStatus.mess.setmessage("危ないっ！");
			eneStatus.mess.message.enabled = true;

			eneStatus.Fade.fade();
			GetComponent<Image>().sprite = eneStatus.yuusya;

			eneStatus.enemyHP = 1000;
			eneStatus.eneAttack = 10000;
        }
    }
}
