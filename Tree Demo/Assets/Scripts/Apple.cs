using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {

	float maxSpeed=400f;

	public GameObject mainBasket;

	Vector3 pos, velocity;
	// Update is called once per frame
	void Update () {
		pos = transform.position;

		velocity = new Vector3 (0, maxSpeed*Time.deltaTime,0);

		pos -= velocity;

		transform.position = pos;
	}
	void OnTriggerEnter2D(){
		Die ();
	}
	void Die(){
		Destroy (gameObject);
	}
}
