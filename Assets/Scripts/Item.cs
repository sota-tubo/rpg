using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour {
	//アイテムコマンドを選択した時の処理
	
	[SerializeField]
	private GameObject itemFrame = null; //アイテムの種類を選択する時の枠
    public bool itemselect { get; set; } //アイテムを選択したかどうか
    [SerializeField]
	private Attack attack = null; //攻撃コマンドの判定をなくすため
	[SerializeField]
	private Magic magic = null; //魔法コマンドの判定をなくすため

    // Use this for initialization
    void Start()
    {
        itemselect = false;
        itemFrame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
		//右クリックでアイテム欄を消す
        if (Input.GetMouseButtonDown(1))
        {
            itemFrame.SetActive(false);
        }
    }
    //アイテムをクリックした時
    public void magicClicked()
    {
		//アイテム欄の表示
        itemFrame.SetActive(true);

        itemselect = true;
        attack.attackselect = false;
		magic.magicselect = false;
    }
}
