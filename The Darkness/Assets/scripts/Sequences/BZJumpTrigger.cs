using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BZJumpTrigger : MonoBehaviour {

    public AudioSource Bushes;
    public AudioSource JumpMusic;
    public GameObject TheZombie;


    void OnTriggerEnter (){
	
		GetComponent<BoxCollider> ().enabled = false;
        Bushes.Play();
        TheZombie.SetActive(true);
        JumpMusic.Play();
        StartCoroutine (PlayJumpMusic ());




    }

    IEnumerator PlayJumpMusic()
	{
		yield return new WaitForSeconds (0.4f);
		JumpMusic.Play ();
	}

}
