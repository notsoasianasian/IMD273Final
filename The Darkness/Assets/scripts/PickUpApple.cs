using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpApple : MonoBehaviour {

    public AudioSource Apple;

    void OnTriggerEnter(Collider other)
    {
        PlayHealth.health += 20;
        Destroy(this.gameObject);
        Apple.Play();
        StartCoroutine(PlayApple());

    }

    IEnumerator PlayApple()
    {
        yield return new WaitForSeconds(0.4f);
        Apple.Play();
    }
}
