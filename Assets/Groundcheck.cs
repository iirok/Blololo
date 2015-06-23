using UnityEngine;
using System.Collections;

public class Groundcheck : MonoBehaviour {

	GameObject plr;
	bool grounded = false;
	bool inair = false;

	// Use this for initialization
	void Start () {
	
		plr = GameObject.FindGameObjectWithTag ("Player");

	}


	void OnTriggerStay2D (Collider2D hit) {

		if (hit.gameObject.tag == "Ground") {
			 grounded = true;
			 inair = false;

		}
	}

	void OnTriggerExit2D (Collider2D hit) {
		if (hit.gameObject.tag == "Ground") {
			grounded = false;
			inair = true;
		}
	}

	// Update is called once per frame
	void Update () {
		if (grounded) {
			plr.SendMessageUpwards ("maassa", SendMessageOptions.DontRequireReceiver);
		}
		if (inair) {
			plr.SendMessageUpwards ("ilmassa", SendMessageOptions.DontRequireReceiver);
		}
	}
}
