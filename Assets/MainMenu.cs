using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour {

//	public AudioMixer audioMixer;
//
//
//	public float volume = 0.6f ;

	public void PlayGame(){

		SceneManager.LoadScene ("Main Level");
	
	}

	public void BackGame(){

		SceneManager.LoadScene (0);

	}
	public void tuGame(){

		SceneManager.LoadScene (2);

	}
	public void creGame(){

		SceneManager.LoadScene (6);

	}
	public void opGame(){

		SceneManager.LoadScene (5);

	}
	public void mute(){

		AudioListener.pause = !AudioListener.pause;

	}


}
