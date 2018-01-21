using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour
{
	public GameObject mainBasket;
	public GameObject basket2,basket3;


	void OnTriggerEnter2D(){
		if (basket3 != null) {
			SoundScript.PlaySound ("Miss");
			Destroy (basket3);
		} else if (basket2 != null) {
			SoundScript.PlaySound ("Miss");
			Destroy (basket2);
		} else if (mainBasket != null) {
			SoundScript.PlaySound ("Fail");
			Destroy (mainBasket);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

