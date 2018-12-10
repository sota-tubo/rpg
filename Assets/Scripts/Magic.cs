using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magic : MonoBehaviour {

	[SerializeField]
	private GameObject magicFrame;
	public bool magicselect { get; set; } //魔法を選択したかどうか
	[SerializeField]
	private Attack attack;

	// Use this for initialization
	void Start () {
		magicselect = false;
		magicFrame.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		if (Input.GetMouseButtonDown(1))
		{
			magicFrame.SetActive(false);
		}
	}
    //まほうをクリックした時
	public void magicClicked()
	{
		magicFrame.SetActive(true);

		magicselect = true;
		attack.attackselect = false;
	}
}
