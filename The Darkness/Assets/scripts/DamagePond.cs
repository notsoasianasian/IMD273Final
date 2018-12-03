using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePond : MonoBehaviour {

    public AudioSource Splash;

    void OnTriggerEnter(Collider other)
    {
        PlayHealth.health -= 100;
        StartCoroutine(PlaySplash());

    }

    IEnumerator PlaySplash()
    {
        yield return new WaitForSeconds(0.4f);
       Splash.Play();
    }
}
