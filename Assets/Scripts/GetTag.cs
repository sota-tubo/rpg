using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTag : MonoBehaviour {

	private AttackEnemy attackenemy;

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
