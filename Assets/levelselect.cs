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


		Application.LoadLevel (1);

	}
	public void level2 () {

			Application.LoadLevel (2);

	}
	public void level3 () {

			Application.LoadLevel (3);

	}
	public void level4 () {
		

			Application.LoadLevel (4);

	}

	public void level5 () {
		

			Application.LoadLevel (5);

	}

	public void level6 () {
		

			Application.LoadLevel (6);

	}

	public void level7 () {
		

			Application.LoadLevel (7);

	}

	public void level8 () {
		

			Application.LoadLevel (8);

	}

	public void level9 () {
		

			Application.LoadLevel (9);

	}

	public void level10 () {
		

			Application.LoadLevel (10);

	}

	public void level11 () {
		

			Application.LoadLevel (11);

	}

	public void level12 () {
		

			Application.LoadLevel (12);

	}

	public void level13 () {
		

			Application.LoadLevel (13);

	}

	public void level14 () {
		

			Application.LoadLevel (14);

	}

	public void level15 () {
		

			Application.LoadLevel (15);

	}

	public void level16 () {
		

			Application.LoadLevel (16);

	}

	public void level17 () {
		

			Application.LoadLevel (17);

	}

	public void level18 () {
		

			Application.LoadLevel (18);

	}

	public void level19 () {
		

			Application.LoadLevel (19);

	}

	public void level20 () {

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
