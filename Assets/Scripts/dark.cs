using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dark : MonoBehaviour {

	private enemyStatus eneStatus;

	private void Start()
	{
		eneStatus = GetComponent<enemyStatus>();
	}

	public void damage(int damagepoint)
    {
		if (eneStatus.magic.magicselect == true)
        {
			eneStatus.enemyHP -= (int)(damagepoint / 2);

			eneStatus.mess.setmessage("敵に" + (int)(damagepoint / 2) + "ポイントのダメージを与えた！");
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
				eneStatus.mess.setmessage("敵は" + -damagepoint + "ポイントのダメージを回復した！");
				eneStatus.mess.message.enabled = true;
            }
        }
    }
}
