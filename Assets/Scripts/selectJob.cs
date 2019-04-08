using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class selectJob : MonoBehaviour {
	//どの職業を選択したのか判定するスクリプト

	public static bool Sol, Kni, Ber, Wiz, Sag, Dar, Yuu, Sch; //どの職業を選んだのか判定
	public static bool Yuusyaflag = false; //ゲームクリア後に勇者が使用可能になる

	private messagetext mess; //上部のメッセージ内容を制御
	private GameObject Yuusya; //勇者のオブジェクトをゲームクリア前は非表示にする

	// Use this for initialization
	void Start () {
		Sol = false;
		Kni = false;
		Ber = false;
		Wiz = false;
		Sag = false;
		Dar = false;
		Sch = false;

		mess = GameObject.Find("messagetext").GetComponent<messagetext>();
		Yuusya = GameObject.Find("Yuusya");

		if (!Yuusyaflag)
		{
			Yuusya.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //pointerはマウスポインターをボタンに重ねている時に表示、selectはボタンを選択した場合に実行

	public void pointerExit()
	{
		mess.setmessage("職業を選んでね！");
	}

    //戦士の場合
	public void pointerSoldier()
	{
		mess.setmessage("能力は普通\n攻撃と一部の魔法が使える");
	}

	public void selectSoldier()
	{
		Sol = true;
		SceneManager.LoadScene("SampleScene");
	}

    //騎士の場合
	public void pointerKnight()
	{
		mess.setmessage("攻撃力が少し高く、体力も高い\n攻撃が使える");
	}

	public void selectKnight()
	{
		Kni = true;
		SceneManager.LoadScene("SampleScene");
	}

    //狂戦士の場合
	public void pointerBerser()
	{
		mess.setmessage("攻撃力が高いが、体力が低い\n攻撃が使える");
	}

	public void selectBerser()
	{
		Ber = true;
		SceneManager.LoadScene("SampleScene");
	}

    //魔法使いの場合
	public void pointerWizard()
	{
		mess.setmessage("魔法の威力が高いが、攻撃力は低い\n攻撃と一部の魔法が使える");
	}

	public void selectWizard()
	{
		Wiz = true;
		SceneManager.LoadScene("SampleScene");
	}

    //賢者の場合
	public void pointerSage()
	{
		mess.setmessage("魔法の威力が高いが、体力が低い\n全ての魔法が使える");
	}

	public void selectSage()
	{
		Sag = true;
		SceneManager.LoadScene("SampleScene");
	}

    //闇の剣士の場合
	public void pointerDark()
	{
		mess.setmessage("全ての攻撃が強力だが、回復できない\n攻撃と回復魔法以外の全ての魔法が使える");
	}

	public void selectDark()
	{
		Dar = true;
		SceneManager.LoadScene("SampleScene");
	}

    //伝説の勇者の場合
	public void pointerYuusya()
	{
		mess.setmessage("全てにおいて最強\n攻撃と全ての魔法が使える");
	}

	public void selectYuusya()
	{
		Yuu = true;
		SceneManager.LoadScene("SampleScene");
	}

    //学者の場合
	public void pointerScholar()
    {
        mess.setmessage("敵を混乱させる特技を使えることができる\n攻撃と一部の魔法が使えるが攻撃力は低い");
    }

    public void selectScholar()
    {
		Sch = true;
        SceneManager.LoadScene("SampleScene");
    }
}
