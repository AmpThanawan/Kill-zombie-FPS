using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Option : MonoBehaviour {

	public AudioMixer audioMixer;
	public float volume = 0.6f ;
	public Slider Volume;
	public AudioSource sound;



	void Update () {
		sound.volume = Volume.value;
	}

		

}
