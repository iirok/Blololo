using UnityEngine;
using System.Collections;

public class Killzone : MonoBehaviour {

	GameObject plr;

	// Use this for initialization
	void Start () {
	
		plr = GameObject.FindGameObjectWithTag ("Player");

	}


	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Groundcheck") {
			plr.SendMessageUpwards ("kuolin", SendMessageOptions.DontRequireReceiver);
		}
	}



	
	// Update is called once per frame
	void Update () {
	
	}
}
