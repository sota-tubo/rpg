using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jobStatus : MonoBehaviour {

	private playerStatus status;

	private void Awake()
	{
		status = GetComponent<playerStatus>();
		jobSta();
		status.playerMAXHP = status.playerHP;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void jobSta()
	{
		//戦士を選んだ場合（基準値 HP100, Attack20, magicAttack20, magicHeal40）
        //騎士を選んだ場合
		if (selectJob.Kni)
		{
			status.playerHP += 50;
			status.playerAttack += 10;
			status.magicAttack = 0;
			status.magicHeal = 0;
		}
        //狂戦士を選んだ場合
		else if (selectJob.Ber)
		{
			status.playerHP -= 20;
			status.playerAttack += 30;
			status.magicAttack = 0;
			status.magicHeal = 0;
		}
		//魔法使いを選んだ場合
		else if (selectJob.Wiz)
		{
			status.playerAttack -= 10;
			status.magicAttack += 20;
			status.magicHeal += 10;
		}
		//賢者を選んだ場合
		else if (selectJob.Sag)
		{
			status.playerHP -= 30;
			status.magicAttack += 20;
			status.magicHeal += 10;
		}
		//闇の戦士を選んだ場合
		else if (selectJob.Dar)
		{
			status.playerHP += 30;
			status.playerAttack += 10;
			status.magicAttack += 20;
			status.magicHeal = 0;
		}
		//伝説の勇者を選んだ場合
		else if (selectJob.Yuu)
		{
			status.playerHP = 1000;
			status.playerAttack = 1000;
			status.magicAttack = 1000;
			status.magicHeal = 1000;
		}
	}
}
