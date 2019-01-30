using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicInfo : MonoBehaviour {

	public bool highmagic { get; set; } //爆炎などの上位魔法かどうかチェック 

	// Use this for initialization
	void Start () {
		//取得の仕方を考え中
		if (gameObject.name == "bakuen")
			highmagic = true;
		else
			highmagic = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
