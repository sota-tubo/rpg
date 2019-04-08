using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myst : MonoBehaviour {
	//謎の魔術師(現段階で3番目の敵)のダメージ処理をするためのスクリプト

	private enemyStatus eneStatus; //敵の体力を参照

	private void Start()
	{
		eneStatus = GetComponent<enemyStatus>();
	}

    //ダメージ処理
	public void damage(int damagepoint, string magictag)
    {
		//雷属性の魔法で攻撃した場合
		if (magictag.Contains("Thunder") == true)
		{
			//雷属性の上位魔法で攻撃した場合(現時点では「ごうらい」)
			if (magictag.Contains("High"))
			{
				eneStatus.enemyHP -= damagepoint * 3;

				eneStatus.mess.setmessage("敵に" + (damagepoint * 3) + "ポイントのダメージを与えた！");
                eneStatus.mess.message.enabled = true;
			}
			//雷属性の上位魔法以外で攻撃した場合(現時点では「かみなり」)
			else
			{
				eneStatus.enemyHP -= damagepoint * 2;

				eneStatus.mess.setmessage("敵に" + (damagepoint * 2) + "ポイントのダメージを与えた！");
                eneStatus.mess.message.enabled = true;
			}
		}
        //雷属性以外で攻撃した場合
		else
		{
			eneStatus.enemyHP -= damagepoint;
			//攻撃した場合のメッセージ表示
			if (damagepoint >= 0)
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
		//最大タメ時の雷属性の攻撃で一撃で倒すことができる(魔法が使えない場合は雷属性の魔法の石とタメを選んで攻撃したとき)(実装予定)

    }
 
}
