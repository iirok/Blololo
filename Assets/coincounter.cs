using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class coincounter : MonoBehaviour {

	GameObject coin;
	public int aika;
	public int elamat;
	public int coins = 0;
	GameObject voithomenu;
	int tmppisteet;
	int vanhatpisteet;
	int kokopisteet;


	// Use this for initialization
	void Start () {
		haepisteet ();
		coin = GameObject.Find ("Canvas/coins");
		voithomenu = GameObject.Find ("Canvas");
	    tmppisteet = 0;
	
	}




	public void haepisteet(){


			vanhatpisteet = PlayerPrefs.GetInt ("pisteet");

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
		Debug.Log (kokopisteet);


		if (coins >= 30) {
		    tmppisteet = ((coins * 10 + aika * 10) * elamat);
			kokopisteet = (vanhatpisteet + tmppisteet);
			PlayerPrefs.SetInt ("pisteet",kokopisteet);
			voithomenu.SendMessageUpwards("victory",kokopisteet, SendMessageOptions.DontRequireReceiver);
		}

		
	}
}
