using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class selectJob : MonoBehaviour {

	public static bool Sol, Kni, Ber, Wiz, Sag, Dar, Yuu, Sch;
	public static bool Yuusyaflag = false;

	private messagetext mess;
	private GameObject Yuusya;

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

	public void pointerExit()
	{
		mess.setmessage("職業を選んでね！");
	}

	public void pointerSoldier()
	{
		mess.setmessage("能力は普通\n攻撃と一部の魔法が使える");
	}

	public void selectSoldier()
	{
		Sol = true;
		SceneManager.LoadScene("SampleScene");
	}

	public void pointerKnight()
	{
		mess.setmessage("攻撃力が少し高く、体力も高い\n攻撃が使える");
	}

	public void selectKnight()
	{
		Kni = true;
		SceneManager.LoadScene("SampleScene");
	}

	public void pointerBerser()
	{
		mess.setmessage("攻撃力が高いが、体力が低い\n攻撃が使える");
	}

	public void selectBerser()
	{
		Ber = true;
		SceneManager.LoadScene("SampleScene");
	}

	public void pointerWizard()
	{
		mess.setmessage("魔法の威力が高いが、攻撃力は低い\n攻撃と一部の魔法が使える");
	}

	public void selectWizard()
	{
		Wiz = true;
		SceneManager.LoadScene("SampleScene");
	}

	public void pointerSage()
	{
		mess.setmessage("魔法の威力が高いが、体力が低い\n全ての魔法が使える");
	}

	public void selectSage()
	{
		Sag = true;
		SceneManager.LoadScene("SampleScene");
	}

	public void pointerDark()
	{
		mess.setmessage("全ての攻撃が強力だが、回復できない\n攻撃と回復魔法以外の全ての魔法が使える");
	}

	public void selectDark()
	{
		Dar = true;
		SceneManager.LoadScene("SampleScene");
	}

	public void pointerYuusya()
	{
		mess.setmessage("全てにおいて最強\n攻撃と全ての魔法が使える");
	}

	public void selectYuusya()
	{
		Yuu = true;
		SceneManager.LoadScene("SampleScene");
	}

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
