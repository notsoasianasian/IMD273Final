using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage10 : MonoBehaviour {

    public AudioSource Punch;

    void OnTriggerEnter(Collider other)
    {
        PlayHealth.health -= 5;
        StartCoroutine(PlayPunch());

    }

    IEnumerator PlayPunch()
    {
        yield return new WaitForSeconds(0.4f);
       Punch.Play();
   }
}
