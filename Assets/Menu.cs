using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	public void startgame () { 

		Application.LoadLevel (1);
	}
	public void button () { }


	public void quitgame () { 
		Application.Quit ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
