using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class coincounter : MonoBehaviour {

	GameObject coin;
	public int coins = 0;
	public int i;

	// Use this for initialization
	void Start () {
	
		coin = GameObject.Find ("Canvas/coins");

		i = Application.loadedLevel;

	}

	void kolikko () {
		coins ++;
	}
	
	// Update is called once per frame
	void Update () {
		
		coin.GetComponent<Text> () .text = "Coins: " + coins;


		if (coins >= 30) {
			Application.LoadLevel (i + 1);
		}

		
	}
}
