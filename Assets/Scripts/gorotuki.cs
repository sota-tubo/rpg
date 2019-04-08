using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gorotuki : MonoBehaviour {
	//ごろつき(現時点で最初の敵)のダメージ処理をするためのスクリプト

	private enemyStatus eneStatus; //敵の体力を参照

	private void Start()
	{
		eneStatus = GetComponent<enemyStatus>();
	}

	public void damage(int damagepoint, string magictag)
	{
		//上位魔法を選択した時(現時点では「ばくえん」と「つなみ」と「ごうらい」)
		if (magictag.Contains("High"))
		{
			damagepoint = (int)(damagepoint * 1.5f);
		}

		eneStatus.enemyHP -= damagepoint;
        //お金を使用した場合
		if (magictag == "Money")
        {
            eneStatus.mess.setmessage("「ラッキー」");
            eneStatus.mess.message.enabled = true;
        }
		//攻撃した場合のメッセージ表示
		else if (damagepoint >= 0)
		{
			eneStatus.mess.setmessage("敵に" + damagepoint + "ポイントのダメージを与えた！");
			eneStatus.mess.message.enabled = true;
		}
		//回復した場合のメッセージ表示
		else
		{
			eneStatus.mess.setmessage("敵は" + -damagepoint + "ポイントのダメージを回復した！");
			eneStatus.mess.message.enabled = true;
        }
	}

}
