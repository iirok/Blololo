using UnityEngine;
using System.Collections;

public class vihucontrol : MonoBehaviour {

	GameObject vihu;


	// Use this for initialization
	void Start () {

		vihu = GameObject.FindGameObjectWithTag ("Enemy1");

	
	}


	void OnTriggerStay2D (Collider2D other) {

			if (other.tag == "Player") {
				vihu.SendMessageUpwards ("aktivointi", SendMessageOptions.DontRequireReceiver);

			}
		}

	void OnTriggerExit2D (Collider2D other) {

		if (other.tag == "Player") {
			vihu.SendMessageUpwards("stop", SendMessageOptions.DontRequireReceiver);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
