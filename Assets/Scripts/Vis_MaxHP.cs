using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vis_MaxHP : MonoBehaviour {
	//プレイヤーの最大体力を表示

	private playerStatus player; //プレイヤーの最大体力を参照
	private Text MAX; //プレイヤーの最大体力を表示

	// Use this for initialization
	void Start () {
		player = GameObject.Find("PlayerHP").GetComponent<playerStatus>();
		MAX = GetComponent<Text>();
		MAX.text = player.playerHP.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{

	}

}
