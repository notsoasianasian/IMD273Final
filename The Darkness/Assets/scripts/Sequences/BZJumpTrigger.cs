using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BZJumpTrigger : MonoBehaviour {

	public AudioSource JumpMusic;
	public GameObject TheEnemy;


	void OnTriggerEnter (){
	
		GetComponent<BoxCollider> ().enabled = false;
		JumpMusic.Play ();
		TheEnemy.SetActive (true);
		StartCoroutine (PlayJumpMusic ());
	}

	IEnumerator PlayJumpMusic()
	{
		yield return new WaitForSeconds (0.4f);
		JumpMusic.Play ();
	}

}
