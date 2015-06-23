using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {
	
	
	bool canpause = true;
	bool soundon = true;

	GameObject paussimenu;

	// Use this for initialization
	void Start () {
	
		paussimenu = transform.Find ("PauseMenu").gameObject;
		paussimenu.SetActive(false);
		Time.timeScale = 1;
		
		
	}

	public void restartti(){
		Application.LoadLevel (Application.loadedLevel);
		
		
	}

	public void resume () {

		Time.timeScale = 1;
		canpause = true;
		paussimenu.SetActive (false);
		GameObject.FindGameObjectWithTag ("Player").GetComponent<ukkeli> ().paussi = false;
	}

	public void tomenu () {
		Application.LoadLevel (0);
	}

	public void togglesound () {
		if (!soundon) {
			soundon = true;
			Debug.Log ("soundon");
			return;
		}
		if (soundon) {
			soundon = false;
			Debug.Log ("soundoff");
			return;
		}

	}




	
	// Update is called once per frame
	void Update () {

		if (!soundon) {
			AudioListener.volume = 0;
		}

		if (soundon) {
			AudioListener.volume = 1;
		}

		if (Input.GetKeyDown (KeyCode.Escape) && canpause) {
			Time.timeScale = 0;
			canpause = false;
			paussimenu.SetActive(true);;
			GameObject.FindGameObjectWithTag("Player").GetComponent<ukkeli>().paussi = true;
			
		} else if (Input.GetKeyDown (KeyCode.Escape)) {
			Time.timeScale = 1;
			canpause = true;
			paussimenu.SetActive(false);
			GameObject.FindGameObjectWithTag("Player").GetComponent<ukkeli>().paussi = false;
		}
		
		
	}
}