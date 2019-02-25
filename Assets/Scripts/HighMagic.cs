using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighMagic : MonoBehaviour {

	[SerializeField]
	private GameObject highmagic = null;

	// Use this for initialization
	void Start () {
		if (selectJob.Sag == true)
		{
			highmagic.SetActive(true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
