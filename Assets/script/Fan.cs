using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour {

	[SerializeField]
	float speed = 200 ;

	void Update () {
		transform.Rotate(0,0,speed * Time.deltaTime);
	}
}
