using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour {

	public static AudioClip hitSound, missSound, failSound,musicSound;
	public static AudioSource audioSrc;
	// Use this for initialization
	void Start () {
		hitSound = Resources.Load<AudioClip> ("Hit");
		missSound = Resources.Load<AudioClip> ("Miss");
		failSound = Resources.Load<AudioClip> ("Fail");
		musicSound = Resources.Load<AudioClip> ("Music");

		audioSrc=GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public static void PlaySound(string clip){
		switch (clip) {
		case "Hit":
			audioSrc.PlayOneShot (hitSound);
			break;
		case "Miss":
			audioSrc.PlayOneShot (missSound);
			break;
		case "Fail":
			audioSrc.PlayOneShot (failSound);
			break;
		case "Music":
			audioSrc.PlayOneShot (musicSound);
			break;
		}
	
	}
}
