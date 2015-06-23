using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class lifecounter : MonoBehaviour {

	GameObject life;
	public int lives = 3;


	// Use this for initialization
	void Start () {
	
		life = GameObject.Find ("Canvas/lives");

	}


	void kuolin () {
		lives --;
	}






	// Update is called once per frame
	void Update () {

		life.GetComponent<Text> () .text = "Lives: " + lives;

		if (lives <= 0) {
			Application.LoadLevel (Application.loadedLevel);
		}
	
	}
}
