using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class magicCount : MonoBehaviour {

    //取得方法考え中
	public int count { get;  set;}

	private Text counttext;

	// Use this for initialization
	void Start () {
		count = 10;
		counttext = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		counttext.text = count.ToString();
	}
}
