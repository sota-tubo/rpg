using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoSwitch : MonoBehaviour {
	//魔法の情報を表示させるスクリプト(実装予定)

	private GameObject infoCanvas; //魔法の情報を表示させるオブジェクト

	// Use this for initialization
	void Start () {
		infoCanvas = transform.Find("infoCanvas").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void pointEnter()
	{
		infoCanvas.SetActive(true);
	}

	public void pointExit()
	{
		infoCanvas.SetActive(false);
	}
}
