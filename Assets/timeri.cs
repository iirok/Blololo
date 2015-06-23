using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timeri : MonoBehaviour {


	public float Aika;
	public float aika1 = 60;
	GameObject timer;
	
	// Use this for initialization
	void Start () {

		timer = GameObject.Find ("Canvas/timeri");

	}
	
	float Timeri = 0;
	// Update is called once per frame
	void Update () {

		timer.GetComponent<Text> () .text = "Time: " + aika1;

		Timeri += Time.deltaTime;
		if (Timeri >= 1) {
			aika1 --;
			Timeri = 0;	
		}

		if (aika1 <= 0) {
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
