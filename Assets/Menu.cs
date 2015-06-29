using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public int complete;

	// Use this for initialization
	void Start () {
		complete = PlayerPrefs.GetInt ("voitho");

	  
	}


	public void startgame () { 
		PlayerPrefs.SetInt ("voitho", 0);
		PlayerPrefs.SetInt ("pisteet", 0);
		Application.LoadLevel (1);
	}
	public void levelselect () { 
	   
		if (complete == 1) {
			Application.LoadLevel (22);
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
	
	}
}
