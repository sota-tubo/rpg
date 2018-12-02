using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSwitch : MonoBehaviour {

	public bool MS { get; set; } //メニューの表示非表示切り替え
	public bool playerTurn { get; set; } //プレイヤーのターンかどうか
	[SerializeField]
	private GameObject attack, magic, item;

	// Use this for initialization
	void Start () {
		MS = true;
		playerTurn = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		if (MS == true)
		{
			gameObject.SetActive(true);
			attack.SetActive(true);
			magic.SetActive(true);
			item.SetActive(true);
		}
		else if (MS == false)
		{
			gameObject.SetActive(false);
			attack.SetActive(false);
			magic.SetActive(false);
			item.SetActive(false);
			playerTurn = false;
		}
	}
}
