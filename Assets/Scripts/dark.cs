using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dark : MonoBehaviour {
	//闇の魔術師(現段階で4番目の敵)のダメージ処理をするためのスクリプト

	private enemyStatus eneStatus; //敵の体力を参照

	private void Start()
	{
		eneStatus = GetComponent<enemyStatus>();
	}

    //ダメージ処理
	public void damage(int damagepoint, string magictag)
    {
		//炎属性の魔法で攻撃した際の処理
		if (magictag == "Fire")
		{
			//炎属性かつ上位魔法で攻撃した場合(現在は「ばくえん」)
			if (magictag.Contains("High"))
			{
				eneStatus.enemyHP -= damagepoint * 3;

				eneStatus.mess.setmessage("敵に" + (damagepoint * 3) + "ポイントのダメージを与えた！");
				eneStatus.mess.message.enabled = true;
			}
			//炎属性の上位魔法以外で攻撃した場合(現在は「ほのお」)
			else
			{
				eneStatus.enemyHP -= damagepoint * 2;

				eneStatus.mess.setmessage("敵に" + (damagepoint * 2) + "ポイントのダメージを与えた！");
				eneStatus.mess.message.enabled = true;
			}
		}
        //炎属性以外の魔法で攻撃した場合
		else if (magictag != "Attack")
        {
			//炎属性以外の上位魔法で攻撃した場合(現在は「つなみ」と「ごうらい」)
			if (magictag.Contains("High"))
			{
				eneStatus.enemyHP -= (int)(damagepoint * 0.75f);
			}
			//炎属性以外の魔法で攻撃/回復した場合(現在は「みず」と「かみなり」と「かいふく」)
			else
			{
				eneStatus.enemyHP -= (int)(damagepoint * 0.5f);
			}

            //攻撃した場合のメッセージ表示
			if (damagepoint >= 0)
            {
				//上位魔法の場合
				if (magictag.Contains("High"))
				{
					eneStatus.mess.setmessage("敵に" + (int)(damagepoint * 0.75f) + "ポイントのダメージを与えた！");
					eneStatus.mess.message.enabled = true;
				}
                //上位魔法以外の場合
				else
				{
					eneStatus.mess.setmessage("敵に" + (int)(damagepoint * 0.5f) + "ポイントのダメージを与えた！");
					eneStatus.mess.message.enabled = true;
				}
            }
            //回復した場合のメッセージ表示
            else
            {
				//上位魔法の場合(現時点では使えない)
				if (magictag.Contains("High"))
				{
					eneStatus.mess.setmessage("敵は" + -(int)(damagepoint * 0.75f) + "ポイントのダメージを回復した！");
					eneStatus.mess.message.enabled = true;
				}
                //上位魔法以外の場合
				else
				{
					eneStatus.mess.setmessage("敵は" + -(int)(damagepoint * 0.5f) + "ポイントのダメージを回復した！");
					eneStatus.mess.message.enabled = true;
				}
            }
        }
        //攻撃した場合
        else
        {
			eneStatus.enemyHP -= damagepoint;
            
			eneStatus.mess.setmessage("敵に" + damagepoint + "ポイントのダメージを与えた！");
			eneStatus.mess.message.enabled = true;
        }
    }
}
