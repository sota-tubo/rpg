using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pageChange : MonoBehaviour {
	//職業選択ページの切り替え

	[SerializeField]
	private GameObject page1 = null, page2 = null; //職業表示一覧の切り替え

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//次のページへ切り替え(page2)
    public void nextpageChange()
	{
		page1.SetActive(false);
		page2.SetActive(true);
	}

	//前のページへ切り替え(page1)
    public void returnpageChange()
	{
		page1.SetActive(true);
		page2.SetActive(false);
	}
}
