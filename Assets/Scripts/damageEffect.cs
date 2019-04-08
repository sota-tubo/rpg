using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damageEffect : MonoBehaviour {
	//プレイヤーがダメージを受けた時のエフェクトを表示させるためのスクリプト
    
	private float alpha; //α値(透明度)

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //ダメージエフェクトの処理をするための関数
	public void playereffect()
	{
		alpha = 0.4f;
		StartCoroutine("DE");
	}

    //ダメージエフェクト表示
	IEnumerator DE()
	{
		GetComponent<Image>().color = new Color(255f, 0f, 0f, alpha);

		GetComponent<Image>().enabled = true;

		yield return new WaitForSeconds(0.05f);

		GetComponent<Image>().enabled = false;

		yield return new WaitForSeconds(0.05f);

		GetComponent<Image>().enabled = true;

        yield return new WaitForSeconds(0.05f);

        GetComponent<Image>().enabled = false;
	}
}
