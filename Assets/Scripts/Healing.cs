using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour {

	[SerializeField]
	private playerStatus player;
	[SerializeField]
	private AttackEnemy at;
	[SerializeField]
	private Magic magic;
	[SerializeField]
	private MenuSwitch menu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //かいふくをクリックした時
	public void clickHeal()
	{
		at.attack = false;

		player.heal(player.magicHeal);

		magic.magicselect = false;
		menu.MS = false;
	}
}
