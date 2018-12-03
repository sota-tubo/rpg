using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	[SerializeField]
	private AttackEnemy enemy;
	[SerializeField]
	private messagetext mess;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void attackSelected()
	{
		Debug.Log("Attack");

		mess.setmessage("どの敵を攻撃する？");
		mess.enabled = true;

		enemy.attack = true;
	}

}
