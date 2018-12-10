using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSwitch : MonoBehaviour {

	public bool MS { get; set; } //メニューの表示非表示切り替え
	public bool playerTurn { get; set; } //プレイヤーのターンかどうか
	[SerializeField]
	private GameObject menu, attack, magic, item;
	[SerializeField]
	private GameObject magitem; //魔法・アイテムの種類を表示させる枠

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
		//メニュー表示
		if (MS == true)
		{
			menu.SetActive(true);
			attack.SetActive(true);
			magic.SetActive(true);
			//item.SetActive(true);
		}
        //メニュー非表示
		else if (MS == false)
		{
			menu.SetActive(false);
			attack.SetActive(false);
			magic.SetActive(false);
			item.SetActive(false);
            //まほうとアイテムの選択枠を消す
			magitem.SetActive(false);
            //メニュー非表示時に左クリックで敵ターンになる
			if (Input.GetMouseButtonDown(0))
			    playerTurn = false;
		}
	}
}
