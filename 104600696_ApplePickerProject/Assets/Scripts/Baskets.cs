using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Baskets : MonoBehaviour {

	private Vector3 moveTo;

	private int chiCnt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveTo = new Vector3 (Mathf.Clamp(Camera.main.ScreenToWorldPoint(Input.mousePosition).x ,-2354,3349),-576f,0f);
		print (Input.mousePosition.x);
		transform.position = moveTo;
	}

	void OnTriggerEnter2D(){
		Score.scoreValue += 1;
		SoundScript.PlaySound ("Hit");
	}

	public void Fail(){
		chiCnt = transform.childCount;
		if (chiCnt == 0) {
			Destroy (gameObject);
		} else {
			Destroy(transform.GetChild (chiCnt - 1));
		}
	}
}
