using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour {
	//フェードアウトを実行させるスクリプト

	public float speed = 0.1f; //フェードアウトする時の速さ
	public float alpha { get; set; } //α値(透明度)

	// Use this for initialization
	void Start () {
		fade();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //フェードアウトを実行させるための関数
	public void fade()
	{
		alpha = 1f;
		GetComponent<Image>().enabled = true;
		StartCoroutine("Fadeout");
	}

    //フェードアウトさせる
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
