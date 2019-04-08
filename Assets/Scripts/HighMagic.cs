using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighMagic : MonoBehaviour {
    //上位魔法を表示させるオブジェクト
	[SerializeField]
	private GameObject highmagic = null; //上位魔法を格納したオブジェクト
	[SerializeField]
	private GameObject Heal = null, HiHeal = null; //闇の戦士用

	// Use this for initialization
	void Start () {
		//賢者or闇の剣士or伝説の勇者は上位魔法を使用可能
		if (selectJob.Sag == true || selectJob.Dar == true || selectJob.Yuu == true)
		{
			highmagic.SetActive(true);
		}
        //闇の剣士は回復魔法が使用不可
		if (selectJob.Dar == true)
		{
			Heal.SetActive(false);
			HiHeal.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
