using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpPaddle : MonoBehaviour {

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject FakePaddle;
	public GameObject RealPaddle;
	public GameObject ExtraCross;
	public GameObject BoatTrigger;

	void Update ()
	{
		TheDistance = PlayerCasting.DistanceFromTarget;
	
	}

	void OnMouseOver()
	{
		if (TheDistance <= 2) {
		}
		ExtraCross.SetActive (true);
		ActionText.GetComponent<Text> ().text = "Pick up Paddle";
		ActionDisplay.SetActive (true);
		ActionText.SetActive (true);
	
		if (Input.GetButtonDown ("Action")) {
			if (TheDistance <= 2) {
				this.GetComponent<BoxCollider> ().enabled = false;
				ActionDisplay.SetActive (false);
				ActionText.SetActive (false);
				FakePaddle.SetActive (false);
				RealPaddle.SetActive (true);
				ExtraCross.SetActive (false);
				BoatTrigger.SetActive (true);
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
