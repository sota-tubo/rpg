using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class magicCount : MonoBehaviour {
	//魔法の回数制限をつけるスクリプト(実装予定)

    //取得方法考え中
	public int count { get;  set;} //魔法の回数

	private Text counttext; //残りの魔法回数を表示
	//private AttackEnemy attack;

	// Use this for initialization
	void Start () {
		count = 10;
		counttext = GetComponent<Text>();
		//attack = GameObject.FindWithTag("Enemy").GetComponent<AttackEnemy>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		counttext.text = count.ToString();
	}

	public void Getmagickind()
	{
		//attack.magiccount = GetComponent<magicCount>();
	}
}
