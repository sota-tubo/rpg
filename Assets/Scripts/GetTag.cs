using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTag : MonoBehaviour {
	//どのコマンド、魔法、アイテムを使用したのか判別させるためにタグを取得するためのスクリプト

	private AttackEnemy attackenemy; //タグ名を格納させるための変数の呼び出し

	// Use this for initialization
	void Start () {
		attackenemy = GameObject.FindWithTag("Enemy").GetComponent<AttackEnemy>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void gettag()
	{
		attackenemy.magickind = gameObject.tag;
		Debug.Log(attackenemy.magickind);
	}
}
