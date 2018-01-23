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

	public List<GameObject> apples = new List<GameObject> ();
	void Start () {
		count = 0;
	}

	void FixedUpdate () {
	
		if (count % 20 == 1) {
			apples.Add(Instantiate (applePrefab,transform.position,transform.rotation));
		}
		n = Random.Range (0,30);
		if (n == 2)
			dir *= -1;
		xPos = gameObject.transform.position.x + dir;

		treePos = new Vector3 (Mathf.Clamp(xPos,-2294,3312),1473f,0);
		gameObject.transform.position = treePos;
		count++;

	}


}
