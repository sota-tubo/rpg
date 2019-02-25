using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighMagic : MonoBehaviour {

	[SerializeField]
	private GameObject highmagic = null;
	[SerializeField]
	private GameObject Heal, HiHeal; //闇の戦士用

	// Use this for initialization
	void Start () {
		if (selectJob.Sag == true || selectJob.Dar == true || selectJob.Yuu == true)
		{
			highmagic.SetActive(true);
		}

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
