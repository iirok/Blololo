using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {


	bool canpause = true;

	// Use this for initialization
	void Start () {


	


	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.P) && canpause) {
			Time.timeScale = 0;
			canpause = false;
			GameObject.FindGameObjectWithTag("Player").GetComponent<ukkeli>().paussi = true;

		} else if (Input.GetKeyDown (KeyCode.P)) {
			Time.timeScale = 1;
			canpause = true;
			GameObject.FindGameObjectWithTag("Player").GetComponent<ukkeli>().paussi = false;
		}

	
	}
}
