using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	GameObject plr;

	// Use this for initialization
	void Start () {

		plr = GameObject.FindGameObjectWithTag ("Player");
	
	}


	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "Player") {
			plr.SendMessageUpwards ("kuolin", SendMessageOptions.DontRequireReceiver);
		}
	}
	    
	
	// Update is called once per frame
	void Update () {
	
	}
}
