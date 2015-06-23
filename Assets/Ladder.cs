using UnityEngine;
using System.Collections;

public class Ladder : MonoBehaviour {

	GameObject plr;
	bool tikkaat = false;
	bool eitikkaita = true;


	// Use this for initialization
	void Start () {

		plr = GameObject.FindGameObjectWithTag ("Player");

	
	}



	void OnTriggerStay2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			tikkaat = true;
			eitikkaita = false;
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			eitikkaita = true;
			tikkaat = false;
		}
	}

	// Update is called once per frame
	void Update () {
	if (tikkaat) {
			plr.SendMessageUpwards ("tikkaat", SendMessageOptions.DontRequireReceiver);
		}
    if (eitikkaita) {
			plr.SendMessageUpwards ("eitikkaita", SendMessageOptions.DontRequireReceiver);

		}
	}
}
