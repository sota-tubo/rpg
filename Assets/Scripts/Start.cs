﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour {
	//ゲームスタートさせるためのスクリプト
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClicked()
	{
		SceneManager.LoadScene("JobSelect");
	}
}
