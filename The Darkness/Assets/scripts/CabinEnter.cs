using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CabinEnter : MonoBehaviour {


	void onTriggerEnter(Collider other) {

		if (other.tag == "Player") {
		
			SceneManager.LoadScene("YouSurvived");
		}

	}
}
