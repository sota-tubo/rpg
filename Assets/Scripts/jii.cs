using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jii : MonoBehaviour {

	private enemyStatus eneStatus;

	private void Start()
	{
		eneStatus = GetComponent<enemyStatus>();
	}

	//ダメージを受けた時
	public void damage(int damagepoint)
    {
		if (damagepoint <= 0f)
        {
			eneStatus.Fade.fade();
			GetComponent<Image>().sprite = eneStatus.jiismile;
			eneStatus.enemyHP = 0;
			//Invoke("smile", 2.0f);
        }
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

	void smile()
	{
		eneStatus.enemyHP = -1;
	}

}
