using UnityEngine;
using System.Collections;

public class levelselect : MonoBehaviour {

	GameObject levelcontrol;



	// Use this for initialization
	void Start () {


	}

	public void goback () {
		Application.LoadLevel (0);
	}


	public void level1 () {

		PlayerPrefs.SetInt ("pisteet", 0);
		Application.LoadLevel (1);

	}
	public void level2 () {
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (2);

	}
	public void level3 () {
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (3);

	}
	public void level4 () {
		PlayerPrefs.SetInt ("pisteet", 0);

			Application.LoadLevel (4);

	}

	public void level5 () {
		PlayerPrefs.SetInt ("pisteet", 0);

			Application.LoadLevel (5);

	}

	public void level6 () {
		
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (6);

	}

	public void level7 () {
		
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (7);

	}

	public void level8 () {
		
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (8);

	}

	public void level9 () {
		
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (9);

	}

	public void level10 () {
		
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (10);

	}

	public void level11 () {
		
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (11);

	}

	public void level12 () {
		
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (12);

	}

	public void level13 () {
		
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (13);

	}

	public void level14 () {
		
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (14);

	}

	public void level15 () {
		
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (15);

	}

	public void level16 () {
		
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (16);

	}

	public void level17 () {
		
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (17);

	}

	public void level18 () {
		
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (18);

	}

	public void level19 () {
		
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (19);

	}

	public void level20 () {
		PlayerPrefs.SetInt ("pisteet", 0);
			Application.LoadLevel (20);
	}






	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Escape))
		{ Application.LoadLevel (0);
			;

	
	}
	}
}
