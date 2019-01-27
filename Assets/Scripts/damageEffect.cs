using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damageEffect : MonoBehaviour {

	//public float speed = 0.3f;
	private float alpha;
	//private bool isEffect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void playereffect()
	{
		//isEffect = true;
		alpha = 0.4f;
		//GetComponent<Image>().enabled = true;
		StartCoroutine("DE");
	}

	IEnumerator DE()
	{
        //Debug.Log(isEffect);
		GetComponent<Image>().color = new Color(255f, 0f, 0f, alpha);
		//alpha += speed;

		GetComponent<Image>().enabled = true;

		yield return new WaitForSeconds(0.05f);

		GetComponent<Image>().enabled = false;

		yield return new WaitForSeconds(0.05f);

		GetComponent<Image>().enabled = true;

        yield return new WaitForSeconds(0.05f);

        GetComponent<Image>().enabled = false;
        /*

		if (alpha <= 0f)
		{
			GetComponent<Image>().enabled = false;
		}
		else if (alpha >= 0.5f)
		{
			isEffect = false;
			alpha -= speed;
			StartCoroutine("DE");
		}
		else
		{
			if (isEffect == false)
			{
				alpha -= speed;
				StartCoroutine("DE");
			}
			else
			{
				alpha += speed;
				StartCoroutine("DE");
			}
		}
		*/
	}
}
