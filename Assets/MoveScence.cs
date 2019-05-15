using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MoveScence : MonoBehaviour {


		
	void OntriggerEnter(Collider other){
		if (other.CompareTag ("Player")) {
			SceneManager.LoadScene (3);
		
		}
	
	}
}
