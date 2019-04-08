using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magic : MonoBehaviour {
	//魔法コマンドを選択したかどうか

	[SerializeField]
	private GameObject magicFrame = null; //まほうの種類を選択する時の枠
	public bool magicselect { get; set; } //魔法を選択したかどうか

	[SerializeField]
	private Attack attack = null; //攻撃を選択したかどうか
	[SerializeField]
	private Item item = null; //アイテムを選択したかどうか

	// Use this for initialization
	void Start () {
		magicselect = false;
		magicFrame.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		//右クリックで魔法選択欄を消す
		if (Input.GetMouseButtonDown(1))
		{
			magicFrame.SetActive(false);
		}
	}
    //まほうをクリックした時
	public void magicClicked()
	{
		//魔法選択欄を表示
		magicFrame.SetActive(true);

		magicselect = true;
		attack.attackselect = false;
		item.itemselect = false;
	}
}
