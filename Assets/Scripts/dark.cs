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
			eneStatus.enemyHP -= damagepoint * 2;

			eneStatus.mess.setmessage("敵に" + (damagepoint * 2) + "ポイントのダメージを与えた！");
            eneStatus.mess.message.enabled = true;
		}
		else if (magictag != "Attack")
        {
			eneStatus.enemyHP -= (int)(damagepoint / 2);

			if (damagepoint >= 0)
            {
				eneStatus.mess.setmessage("敵に" + (int)(damagepoint / 2) + "ポイントのダメージを与えた！");
                eneStatus.mess.message.enabled = true;
            }
            else
            {
				eneStatus.mess.setmessage("敵は" + (int)(-damagepoint / 2) + "ポイントのダメージを回復した！");
                eneStatus.mess.message.enabled = true;
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
