using UnityEngine;
using System.Collections;

public class kyltti0 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player")
			Debug.Log ("blolo");
	}

	// Update is called once per frame
	void Update () {
	
	}
}
