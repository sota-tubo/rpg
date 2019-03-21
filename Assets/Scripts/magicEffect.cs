using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicEffect : MonoBehaviour {

	private FadeScript Fade;

	// Use this for initialization
	void Start () {
		Fade = GameObject.Find("FadeSystem").GetComponent<FadeScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeEffect(string magickind)
	{
		//火の魔法の場合
		if (magickind.Contains("Fire"))
		{
			
			GameObject magiceffect = GameObject.Find("FireEffects");

			List<GameObject> effectList = new List<GameObject>();
			foreach (Transform child in magiceffect.transform)
			{
				effectList.Add(child.gameObject);
			}
            
			StartCoroutine(Effect(effectList[0], effectList[1]));
            
			if (magickind.Contains("High"))
			{
				//上級魔法専用のエフェクトを実装予定
			}
		}
		//水の魔法の場合
		else if (magickind.Contains("Water"))
		{
			GameObject magiceffect = GameObject.Find("WaterEffects");

            List<GameObject> effectList = new List<GameObject>();
            foreach (Transform child in magiceffect.transform)
            {
                effectList.Add(child.gameObject);
            }

            StartCoroutine(Effect(effectList[0], effectList[1]));

            if (magickind.Contains("High"))
            {
                //上級魔法専用のエフェクトを実装予定
            }
		}
        //雷の魔法の場合
		else if (magickind.Contains("Thunder"))
        {
            GameObject magiceffect = GameObject.Find("ThunderEffects");

            List<GameObject> effectList = new List<GameObject>();
            foreach (Transform child in magiceffect.transform)
            {
                effectList.Add(child.gameObject);
            }

            StartCoroutine(Effect(effectList[0], effectList[1]));

            if (magickind.Contains("High"))
            {
                //上級魔法専用のエフェクトを実装予定
            }
        }
        
	}

	private IEnumerator Effect(GameObject effect1, GameObject effect2)
	{
		effect1.SetActive(true);

		yield return new WaitForSeconds(0.2f);
        
        //敵の体力によって挙動を変える
		if (Fade.alpha > 0f)
		{
			effect1.SetActive(false);
		}
		else
		{
			effect1.SetActive(false);
			effect2.SetActive(true);

			yield return new WaitForSeconds(0.2f);


			effect1.SetActive(true);
			effect2.SetActive(false);

			yield return new WaitForSeconds(0.2f);

			effect1.SetActive(false);
			effect2.SetActive(true);

			yield return new WaitForSeconds(0.2f);

			effect2.SetActive(false);
		}
	}
}
