using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myst : MonoBehaviour {

	private enemyStatus eneStatus;

	private void Start()
	{
		eneStatus = GetComponent<enemyStatus>();
	}

	public void damage(int damagepoint, string magictag)
    {
		if (magictag == "Thunder")
		{
			eneStatus.enemyHP -= damagepoint * 2;

			eneStatus.mess.setmessage("敵に" + (damagepoint * 2) + "ポイントのダメージを与えた！");
            eneStatus.mess.message.enabled = true;
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
                eneStatus.mess.setmessage("敵は" + damagepoint + "ポイントのダメージを回復した！");
                eneStatus.mess.message.enabled = true;
            }
		}
    }
 
}
