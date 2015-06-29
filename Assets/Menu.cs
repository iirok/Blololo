using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public int complete;
	GameObject nope;
	GameObject sure;
	bool valinta = false;
	bool firstrun = true;

	// Use this for initialization
	void Start () {

		if (firstrun) {
			complete = 0;
		}

		complete = PlayerPrefs.GetInt ("voitho");
		nope = GameObject.Find("Canvas/nopemessage").gameObject;
		nope.SetActive (false);
		sure = GameObject.Find ("Canvas/varmistus") .gameObject;
		sure.SetActive (false);
	  
	}


	public void startgame () { 
		if (complete == 0) {
			firstrun = false;
			PlayerPrefs.SetInt ("voitho", 0);
			PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (1);
		}

		if (complete == 1) {
			sure.SetActive (true);
			valinta = true;

		  }

	}


	public void levelselect () { 
	   
		if (complete == 1) {
			Application.LoadLevel (22);
		} else {
			nope.SetActive (true);
		}
	}


	public void quitgame () { 
		Application.Quit ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
	}
	
		if (valinta) {
			if (Input.GetKeyDown (KeyCode.Y)){
				PlayerPrefs.SetInt ("voitho", 0);
				PlayerPrefs.SetInt ("pisteet", 0);
				Application.LoadLevel (1);
			}
			if (Input.GetKeyDown(KeyCode.N)) {
				sure.SetActive (false);
				valinta = false;
			}
		}


	}
}
