using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSwitch : MonoBehaviour {
	//メニューの表示非表示を制御するスクリプト

	public bool MS { get; set; } //メニューの表示非表示切り替え
	public bool playerTurn { get; set; } //プレイヤーのターンかどうか
	[SerializeField]
	private GameObject menu = null, attack = null, magic = null, item = null, skill = null; //メニュー関連全般
	[SerializeField]
	private GameObject magframe = null, itemframe = null; //魔法・アイテムの種類を表示させる枠
	[SerializeField]
	private GameObject HighMagic = null; //上位魔法が格納されているオブジェクト
	[SerializeField]
	private Text skilltext = null; //skillオブジェクトのテキスト

	// Use this for initialization
	void Start () {
		MS = true;
		playerTurn = true;
        
        //賢者or闇の剣士or伝説の勇者の場合上位魔法を表示
		if (selectJob.Sag || selectJob.Dar || selectJob.Yuu)
		{
			HighMagic.SetActive(true);
		}

        //学者の場合
		if (selectJob.Sch)
		{
			skillkind();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		//メニュー表示
		if (MS)
		{
			menu.SetActive(true);
			item.SetActive(true);
			visMenu();
		}
        //メニュー非表示
		else if (!MS)
		{
			menu.SetActive(false);
			item.SetActive(false);
			invisMenu();
            //まほうとアイテムの選択枠を消す
			magframe.SetActive(false);
			itemframe.SetActive(false);
            //メニュー非表示時に左クリックで敵ターンになる
			if (Input.GetMouseButtonDown(0))
			    playerTurn = false;
		}

	}

	private void visMenu()
	{
		//学者の場合
		if (selectJob.Sch)
		{
			attack.SetActive(true);
			magic.SetActive(true);
			skill.SetActive(true);
		}
		//戦士or魔法使いor闇の戦士or伝説の勇者の場合
		else if (selectJob.Sol || selectJob.Wiz || selectJob.Dar || selectJob.Yuu)
		{
            attack.SetActive(true);
            magic.SetActive(true);
		}
		//騎士or狂戦士の場合
		else if (selectJob.Kni || selectJob.Ber)
		{
			attack.SetActive(true);
		}
		//賢者の場合
		else if (selectJob.Sag)
		{
			magic.SetActive(true);
		}
	}

	private void invisMenu()
	{
		//学者の場合
        if (selectJob.Sch)
        {
			attack.SetActive(false);
			magic.SetActive(false);
			skill.SetActive(false);
        }
		//戦士or魔法使いor闇の戦士or伝説の勇者の場合
        else if (selectJob.Sol || selectJob.Wiz || selectJob.Dar || selectJob.Yuu)
        {
			attack.SetActive(false);
			magic.SetActive(false);
        }
        //騎士or狂戦士の場合
        else if (selectJob.Kni || selectJob.Ber)
        {
			attack.SetActive(false);
        }
        //賢者の場合
        else if (selectJob.Sag)
        {
			magic.SetActive(false);
        }
	}

	private void skillkind()
	{
		//学者の場合
		if (selectJob.Sch)
		{
			skill.tag = "confuse";
			skilltext.text = "こうしき";
		}
	}
}
