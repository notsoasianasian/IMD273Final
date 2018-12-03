using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpKey2 : MonoBehaviour {

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject FakeKey;
	public GameObject RealKey;
	public GameObject ExtraCross;
	public GameObject Door2Trigger;

	void Update ()
	{
		TheDistance = PlayerCasting.DistanceFromTarget;
	
	}

	void OnMouseOver()
	{
		if (TheDistance <= 2) {
		}
		ExtraCross.SetActive (true);
		ActionText.GetComponent<Text> ().text = "Pick up Cabin Key";
		ActionDisplay.SetActive (true);
		ActionText.SetActive (true);
	
		if (Input.GetButtonDown ("Action")) {
			if (TheDistance <= 2) {
				this.GetComponent<BoxCollider> ().enabled = false;
				ActionDisplay.SetActive (false);
				ActionText.SetActive (false);
				FakeKey.SetActive (false);
				RealKey.SetActive (true);
				ExtraCross.SetActive (false);
				Door2Trigger.SetActive (true);
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
