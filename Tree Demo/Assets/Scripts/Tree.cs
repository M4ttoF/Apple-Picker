using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour {

	public float treeSpeed;

	public float spawnRate=0;

	public Vector3 treePos;

	public string projectileType;


	public float dir = 200f;

	private int n,count;

	private float xPos,move;

	public GameObject applePrefab;


	void Start () {
		count = 0;
	}

	void FixedUpdate () {
		if (count % 50 == 1) {
			Drop ();
		}
		n = Random.Range (0,30);
		if (n == 2)
			dir *= -1;
		xPos = gameObject.transform.position.x + dir;

		treePos = new Vector3 (Mathf.Clamp(xPos,121,881),364f,0);
		gameObject.transform.position = treePos;
		count++;

	}

	void Drop(){
		Debug.Log ("Test");
		Instantiate (applePrefab,transform.position,transform.rotation);
	}
}
