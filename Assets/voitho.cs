using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class voitho : MonoBehaviour {

	public int i;
	
	GameObject voitto;
	GameObject pojo;
	public int kokopisteet;
	
	// Use this for initialization
	void Start () {
		
		voitto = transform.Find ("Voithopaneeli").gameObject;
		voitto.SetActive(false);
		Time.timeScale = 1;

		kokopisteet = PlayerPrefs.GetInt ("pisteet");


		i = Application.loadedLevel;
	}
	
	void victory () {
		
		Time.timeScale = 0;
		voitto.SetActive (true);
		pojo = GameObject.Find ("Canvas/Voithopaneeli/Pojot");
		pojo.GetComponent<Text> () .text = "Points: " + kokopisteet;
	}
	
	public void ok () {
		Application.LoadLevel (i + 1);
	}
	
	
	
	
	// Update is called once per frame
	void Update () {

		
	}
}