using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyDamageEffect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void effectOn()
	{
		StartCoroutine("enemyEffect");
	}

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
