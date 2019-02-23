using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoSwitch : MonoBehaviour {

	private GameObject infoCanvas;

	// Use this for initialization
	void Start () {
		infoCanvas = transform.FindChild("infoCanvas").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void pointEnter()
	{
		infoCanvas.SetActive(true);
	}

	public void pointExit()
	{
		infoCanvas.SetActive(false);
	}
}
