using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour {
	//タイトル画面に戻る時のスクリプト

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClicked()
	{
		SceneManager.LoadScene("Title");
	}
}
