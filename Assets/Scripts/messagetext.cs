using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messagetext : MonoBehaviour {

	public Text message { get; set; }

	// Use this for initialization
	void Start () {
		message = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //上部メッセージ書き換え
	public void setmessage(string messtr)
	{
		message.text = messtr;
	}
}
