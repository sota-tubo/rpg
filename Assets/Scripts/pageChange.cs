using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pageChange : MonoBehaviour {

	[SerializeField]
	private GameObject page1, page2; //職業表示一覧の切り替え

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void nextpageChange()
	{
		page1.SetActive(false);
		page2.SetActive(true);
	}

    public void returnpageChange()
	{
		page1.SetActive(true);
		page2.SetActive(false);
	}
}
