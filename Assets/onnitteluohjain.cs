using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class onnitteluohjain : MonoBehaviour {

	GameObject pojot;
	int kokopojot;

	// Use this for initialization
	void Start () {
		pojot = GameObject.Find ("Canvas/Pojot");
		kokopojot = PlayerPrefs.GetInt ("pisteet");
		PlayerPrefs.SetInt ("voitho", 1);
	}




	// Update is called once per frame
	void Update () {
	
		pojot.GetComponent<Text> () .text = "Total Points: " + kokopojot;

		if (Input.GetKey (KeyCode.Return)) {
			Application.LoadLevel (0);
		}


	}
}
