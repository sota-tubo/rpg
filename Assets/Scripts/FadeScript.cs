using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour {

	public float speed = 0.1f;
	public float alpha { get; set; }

	// Use this for initialization
	void Start () {
		fade();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void fade()
	{
		alpha = 1f;
		GetComponent<Image>().enabled = true;
		StartCoroutine("Fadeout");
	}

	IEnumerator Fadeout()
	{
		GetComponent<Image>().color = new Color(255f, 255f, 255f, alpha);
		alpha -= speed;

		yield return new WaitForSeconds(0.1f);

		if (alpha <= 0f)
		{
			GetComponent<Image>().enabled = false;
		}
		else
		{
			StartCoroutine("Fadeout");
		}
	}

}
