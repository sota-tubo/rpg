using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messagetext : MonoBehaviour {

	private Text message;

	// Use this for initialization
	void Start () {
		message = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setmessage(string messtr)
	{
		message.text = messtr;
	}
}
