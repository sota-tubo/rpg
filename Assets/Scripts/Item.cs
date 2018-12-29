using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour {
	
	[SerializeField]
    private GameObject itemFrame; //アイテムの種類を選択する時の枠
    public bool itemselect { get; set; } //アイテムを選択したかどうか
    [SerializeField]
    private Attack attack;

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
        if (Input.GetMouseButtonDown(1))
        {
            itemFrame.SetActive(false);
        }
    }
    //アイテムをクリックした時
    public void magicClicked()
    {
        itemFrame.SetActive(true);

        itemselect = true;
        attack.attackselect = false;
    }
}
