using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	[SerializeField]
	private AttackEnemy enemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void attackSelected()
	{
		Debug.Log("Attack");
		enemy.attack = true;
	}

}
