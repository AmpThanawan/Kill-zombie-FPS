using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyHealth : MonoBehaviour {

	public float enermyHealth = 100f;
	EnemyAI enermyAI;
	public ParticleSystem blood;

	// Use this for initialization
	void Start () {
		blood.Stop ();
		enermyAI = GetComponent<EnemyAI> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DeductHealth(float deductHealth)
	{
		StartCoroutine (BloodEffects());

		enermyHealth -= deductHealth;

		if (enermyHealth <= 0) {
			EnermyDead ();
		}
	}

	void EnermyDead()
	{
		enermyAI.EnermyDeathAnim ();
		Destroy (gameObject,5);
	}

	IEnumerator BloodEffects (){
		blood.Play ();
		yield return new WaitForEndOfFrame ();
		blood.Stop ();
	}

}
