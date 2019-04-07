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
			damagepoint = (int)(damagepoint * 1.5f);
		}

		eneStatus.enemyHP -= damagepoint;

		if (magictag == "Money")
        {
            eneStatus.mess.setmessage("「ラッキー」");
            eneStatus.mess.message.enabled = true;
        }
		else if (damagepoint >= 0)
		{
			eneStatus.mess.setmessage("敵に" + damagepoint + "ポイントのダメージを与えた！");
			eneStatus.mess.message.enabled = true;
		}
		else
		{
			eneStatus.mess.setmessage("敵は" + -damagepoint + "ポイントのダメージを回復した！");
			eneStatus.mess.message.enabled = true;
        }
	}

}
