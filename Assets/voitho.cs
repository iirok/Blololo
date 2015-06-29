using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class voitho : MonoBehaviour {

	public int i;
	int kokopisteet;
	GameObject voitto;
	GameObject pojo;
	
	// Use this for initialization
	void Start () {
		
		voitto = transform.Find ("Voithopaneeli").gameObject;
		voitto.SetActive(false);
		Time.timeScale = 1;




		i = Application.loadedLevel;
	}
	
	void victory () {
		
		Time.timeScale = 0;
		voitto.SetActive (true);
		kokopisteet = PlayerPrefs.GetInt ("pisteet");
		pojo = GameObject.Find ("Canvas/Voithopaneeli/Pojot");
		pojo.GetComponent<Text> () .text = "Points: " + kokopisteet;
		if (Input.GetKey (KeyCode.Return)) {

			Application.LoadLevel (i + 1);
		}
	}
	

	public void ok () {
		Application.LoadLevel (i + 1);
	}


	
	
	
	// Update is called once per frame
	void Update () {

		
	}
}