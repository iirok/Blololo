using UnityEngine;
using System.Collections;

public class kolikko : MonoBehaviour {


	GameObject levelcontrol;

	// Use this for initialization
	void Start () {

		levelcontrol = GameObject.FindGameObjectWithTag ("levelcontrol");
	
	}


	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player") {
			Destroy(gameObject);
			levelcontrol.SendMessageUpwards ("kolikko", SendMessageOptions.DontRequireReceiver);
		}
	}


	// Update is called once per frame
	void Update () {
	
	}
}
