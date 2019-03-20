using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gorotuki : MonoBehaviour {

	private enemyStatus eneStatus;

	private void Start()
	{
		eneStatus = GetComponent<enemyStatus>();
	}

	public void damage(int damagepoint, string magictag)
	{
		if (magictag.Contains("High"))
		{
			eneStatus.enemyHP -= (int)(damagepoint * 1.5f);
		}
		else
		{
			eneStatus.enemyHP -= damagepoint;
		}

		if (damagepoint >= 0)
		{
			eneStatus.mess.setmessage("敵に" + (int)(damagepoint * 1.5f) + "ポイントのダメージを与えた！");
			eneStatus.mess.message.enabled = true;
		}
		else
		{
			eneStatus.mess.setmessage("敵は" + (int)(damagepoint * 1.5f) + "ポイントのダメージを回復した！");
			eneStatus.mess.message.enabled = true;
        }
	}

}
