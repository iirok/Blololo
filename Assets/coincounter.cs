﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class coincounter : MonoBehaviour {

	GameObject coin;
	public int aika;
	public int elamat;
	public int coins = 0;
	GameObject voithomenu;



	// Use this for initialization
	void Start () {
		haepisteet ();
		coin = GameObject.Find ("Canvas/coins");
		voithomenu = GameObject.Find ("Canvas");
	
	}
	int kokopisteet = 0;
	public void haepisteet(){
			if (Application.loadedLevelName == "menu") {
			PlayerPrefs.SetInt ("pisteet", 0);
		}
			kokopisteet = PlayerPrefs.GetInt ("pisteet");

	}
	

	void kolikko () {
		coins ++;
	}


	void elama () {

	}

	
	// Update is called once per frame
	void Update () {


		elamat =	GetComponent<lifecounter> () .lives;
		aika = GetComponent<timeri> () .aika1;


		coin.GetComponent<Text> () .text = "Coins: " + coins;

		if (coins >= 30) {
			voithomenu.SendMessageUpwards("victory",kokopisteet, SendMessageOptions.DontRequireReceiver);
			int tmppisteet = ((coins * 10 + aika * 10) * elamat);
			tmppisteet += kokopisteet;
			PlayerPrefs.SetInt ("pisteet",tmppisteet);
		}

		
	}
}
