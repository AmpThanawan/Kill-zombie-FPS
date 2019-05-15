using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class pistol : MonoBehaviour {

	RaycastHit hit;

	//Used to damage enermy
	[SerializeField]
	float damageEnermy = 10f;

	[SerializeField]
	Transform shootPoint;

	[SerializeField]
	int currentAmmo;

	//Weapon Effect
	//Muzzleflash
	public ParticleSystem muzzleflash;

	//Eject bullet  casing
	public ParticleSystem bulletCasing;

	//Gun Audio
	AudioSource gunAs;
	public AudioClip shootAC;

	//Rate Od Fire
	[SerializeField]
	float rateOfFire;
	float nextFire = 0 ;

	[SerializeField]
	float weaponRange;

	// Use this for initialization
	void Start () {
		muzzleflash.Stop ();
		bulletCasing.Stop ();
		gunAs = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") && currentAmmo > 0) 
		{
			Shoot ();
		}

	}



	void Shoot()
	{
		if (Time.time > nextFire) 
		{
			nextFire = Time.time + rateOfFire;

			currentAmmo--;

			gunAs.PlayOneShot (shootAC);

			StartCoroutine (WeaponEffects ());

			if (Physics.Raycast (shootPoint.position, shootPoint.forward, out hit, weaponRange)) 
			{
				if (hit.transform.tag == "Enermy") {
					Debug.Log ("Hit Enermy");
					EnermyHealth enermyHealthScript = hit.transform.GetComponent<EnermyHealth> ();
					enermyHealthScript.DeductHealth (damageEnermy);
				} else if(hit.transform.tag == "wall"){
					
					SceneManager.LoadScene ("aaa");
					Debug.Log ("Hit wall");
				} else if(hit.transform.tag == "wall2"){

					SceneManager.LoadScene ("next");
					Debug.Log ("Hit wall");
				}else {
					Debug.Log ("Hit Something else");
				}
			}
		}
	}

	IEnumerator WeaponEffects()
	{
		bulletCasing.Play ();
		muzzleflash.Play ();
		yield return new WaitForEndOfFrame ();
		muzzleflash.Stop ();
		bulletCasing.Stop ();
	}
}
