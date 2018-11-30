using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpFlashLight : MonoBehaviour {

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject FakeFlash;
	public GameObject RealFlash;
	public GameObject ExtraCross;
	public GameObject TheJumpTrigger;

	void Update ()
	{
		TheDistance = PlayerCasting.DistanceFromTarget;
	
	}

	void OnMouseOver()
	{
		if (TheDistance <= 2) {
		}
		ExtraCross.SetActive (true);
		ActionText.GetComponent<Text> ().text = "Pick up Flashlight";
		ActionDisplay.SetActive (true);
		ActionText.SetActive (true);
	
		if (Input.GetButtonDown ("Action")) {
			if (TheDistance <= 2) {
				this.GetComponent<BoxCollider> ().enabled = false;
				ActionDisplay.SetActive (false);
				ActionText.SetActive (false);
				FakeFlash.SetActive (false);
				RealFlash.SetActive (true);
				ExtraCross.SetActive (false);
				TheJumpTrigger.SetActive (true);
			}
		}
	}

		void OnMouseExit() 
		{
			ExtraCross.SetActive (false);
			ActionDisplay.SetActive (false);
			ActionText.SetActive (false);
		}

}
