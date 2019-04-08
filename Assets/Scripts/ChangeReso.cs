using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeReso : MonoBehaviour {
	//ゲームの解像度を固定するスクリプト

	private void Awake()
	{
		Screen.SetResolution(1024, 768, true, 60);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
