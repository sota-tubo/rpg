using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	public bool attackselect { get; set; }

	[SerializeField]
	private AttackEnemy enemy;
	[SerializeField]
	private messagetext mess;
	[SerializeField]
	private Magic magic;

	// Use this for initialization
	void Start () {
		attackselect = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		if(Input.GetMouseButtonDown(1) && attackselect == true)
		{
			mess.message.enabled = false;
			attackselect = false;
			enemy.attack = false;
		}
	}
    //こうげき選択時
	public void attackSelected()
	{
		Debug.Log("Attack");

		attackselect = true;
		magic.magicselect = false;

		mess.setmessage("どの敵を攻撃する？");
		mess.message.enabled = true;

		enemy.attack = true;
	}

}
