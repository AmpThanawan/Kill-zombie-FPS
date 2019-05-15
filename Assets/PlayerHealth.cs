using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour {


	public static PlayerHealth sigleton;
	public float currentHealth;
	public float maxHealth = 100f;
	public bool isDead = false;
	public ParticleSystem bloodP;



	private void Awake(){
		sigleton = this;
	}
	// Use this for initialization
	void Start () {
		bloodP.Stop ();
		currentHealth = maxHealth;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (currentHealth < 0) {
			currentHealth = 0;
		}
	}

	public void PlayerDamage(float damage){

		StartCoroutine (BloodPEffects());
		if (currentHealth > 0) {
			currentHealth -= damage;
		} else {
			Dead ();
		}
	

	}
	void Dead(){

		SceneManager.LoadScene (4);
		currentHealth = 0;
		isDead = true;
		Debug.Log("Player Is Dead");
	}

	IEnumerator BloodPEffects (){
		bloodP.Play ();
		yield return new WaitForEndOfFrame ();
		bloodP.Stop ();
	}
}
