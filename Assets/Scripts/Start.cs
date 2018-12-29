using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClicked()
	{
		SceneManager.LoadScene("SampleScene");
	}
}
