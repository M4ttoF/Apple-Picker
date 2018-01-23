using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour
{
	public GameObject mainBasket;
	public GameObject basket2,basket3;

	public GameObject tree;

	public Tree mainTree;

	void Start(){
		mainTree = tree.GetComponent (typeof(Tree)) as Tree;
	}
	void OnTriggerEnter2D(Collider2D other){
		foreach (GameObject a in mainTree.apples) {
			Destroy (a);
		}
		if (basket3 != null) {
			SoundScript.PlaySound ("Miss");
			Destroy (basket3);
		} else if (basket2 != null) {
			SoundScript.PlaySound ("Miss");
			Destroy (basket2);
		} else if (mainBasket != null) {
			SoundScript.PlaySound ("Fail");
			Destroy (mainBasket);
			Delay ();
			Application.Quit ();
		}
	}
	IEnumerator Delay(){
		yield return new WaitForSeconds (2);
	} 
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

