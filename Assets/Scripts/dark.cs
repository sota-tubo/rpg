using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dark : MonoBehaviour {

	private enemyStatus eneStatus;

	private void Start()
	{
		eneStatus = GetComponent<enemyStatus>();
	}

	public void damage(int damagepoint, string magictag)
    {
		if (magictag == "Fire")
		{
			if (magictag.Contains("High"))
			{
				eneStatus.enemyHP -= damagepoint * 3;

				eneStatus.mess.setmessage("敵に" + (damagepoint * 3) + "ポイントのダメージを与えた！");
				eneStatus.mess.message.enabled = true;
			}
			else
			{
				eneStatus.enemyHP -= damagepoint * 2;

				eneStatus.mess.setmessage("敵に" + (damagepoint * 2) + "ポイントのダメージを与えた！");
				eneStatus.mess.message.enabled = true;
			}
		}
		else if (magictag != "Attack")
        {
			if (magictag.Contains("High"))
			{
				eneStatus.enemyHP -= (int)(damagepoint * 0.75f);
			}
			else
			{
				eneStatus.enemyHP -= (int)(damagepoint * 0.5f);
			}

			if (damagepoint >= 0)
            {
				if (magictag.Contains("High"))
				{
					eneStatus.mess.setmessage("敵に" + (int)(damagepoint * 0.75f) + "ポイントのダメージを与えた！");
					eneStatus.mess.message.enabled = true;
				}
				else
				{
					eneStatus.mess.setmessage("敵に" + (int)(damagepoint * 0.5f) + "ポイントのダメージを与えた！");
					eneStatus.mess.message.enabled = true;
				}
            }
            else
            {
				if (magictag.Contains("High"))
				{
					eneStatus.mess.setmessage("敵は" + -(int)(damagepoint * 0.75f) + "ポイントのダメージを回復した！");
					eneStatus.mess.message.enabled = true;
				}
				else
				{
					eneStatus.mess.setmessage("敵は" + -(int)(damagepoint * 0.5f) + "ポイントのダメージを回復した！");
					eneStatus.mess.message.enabled = true;
				}
            }
        }
        else
        {
			eneStatus.enemyHP -= damagepoint;

			if (damagepoint >= 0)
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
}
