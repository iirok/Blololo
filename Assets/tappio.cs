using UnityEngine;
using System.Collections;

public class tappio : MonoBehaviour {


	GameObject turpaantuli;

	// Use this for initialization
	void Start () {

		turpaantuli = transform.Find ("tappiopaneeli").gameObject;
		turpaantuli.SetActive(false);
		Time.timeScale = 1;
	
	}

	void turpasauna () {

		Time.timeScale = 0;
		turpaantuli.SetActive (true);
		if (Input.GetKey (KeyCode.Return))
		{ Application.LoadLevel (Application.loadedLevel);
		}
	}

	public void ok () {
		Application.LoadLevel (Application.loadedLevel);
	}




	// Update is called once per frame
	void Update () {
	
	}
}
