using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class BFirstTrigger : MonoBehaviour {

	public GameObject ThePlayer;
	public GameObject TextBox;
	public GameObject TheMarker;

	void OnTriggerEnter () {
		ThePlayer.GetComponent<FirstPersonController> ().enabled = false;
		StartCoroutine (ScenePlayer ());
        this.GetComponent<BoxCollider>().enabled = false;

    }

	IEnumerator ScenePlayer ()
	{
		TextBox.GetComponent<Text> ().text = "Looks like the bridge is out.";
		yield return new WaitForSeconds (2.5f);
		TextBox.GetComponent<Text> ().text = "I need to find a way over there.";
		yield return new WaitForSeconds (2.5f);
		TextBox.GetComponent<Text> ().text = "";
		ThePlayer.GetComponent<FirstPersonController> ().enabled = true;
		TheMarker.SetActive (false);
	}
}
