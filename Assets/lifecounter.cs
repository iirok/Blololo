using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class lifecounter : MonoBehaviour {

	GameObject life;
	GameObject kolikko;
	public int lives = 3;
	GameObject tappiomenu;
	bool defeat = false;


	// Use this for initialization
	void Start () {

		life = GameObject.Find ("Canvas/lives");
		kolikko = GameObject.Find ("levelcontrol/coincounter");
		tappiomenu = GameObject.Find ("Canvas");



	}


	void kuolin () {
		lives --;
	}






	// Update is called once per frame
	void Update () {
		life.GetComponent<Text> () .text = "Lives: " + lives;

		if (lives <= 0) {
			defeat = true;
		}

		if (defeat) {
			
		tappiomenu.SendMessageUpwards("turpasauna",SendMessageOptions.DontRequireReceiver);

		}
	}




	}




