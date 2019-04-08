using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyDamageEffect : MonoBehaviour {
	//敵にダメージを与えた時のエフェクトを表示するためのスクリプト

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //敵を選択した時にダメージエフェクトを表示させる関数
	public void effectOn()
	{
		StartCoroutine("enemyEffect");
	}
    //ダメージエフェクト表示
	public IEnumerator enemyEffect()
	{
		Image enemy = GetComponent<Image>();

		enemy.enabled = false;

		yield return new WaitForSeconds(0.05f);

		enemy.enabled = true;

		yield return new WaitForSeconds(0.05f);

		enemy.enabled = false;

        yield return new WaitForSeconds(0.05f);

        enemy.enabled = true;
	}
}
