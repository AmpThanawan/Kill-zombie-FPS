﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {


	Light theLight;

	[SerializeField]
	float minTimeBeforeLightFlickers;

	[SerializeField]
	float maxTimeBeforeLightFlickers;

	// Use this for initialization
	void Start () {
		theLight = GetComponent<Light> ();
		StartCoroutine ("MakeLightFicker");
	}

	IEnumerator MakeLightFicker()
	{
		while (true) {
			yield return new WaitForSeconds (Random.Range (minTimeBeforeLightFlickers, maxTimeBeforeLightFlickers));
			theLight.enabled = !theLight.enabled;
		}

	}

	// Update is called once per frame
	void Update () {
		
	}
}
