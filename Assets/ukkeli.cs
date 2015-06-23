using UnityEngine;
using System.Collections;

public class ukkeli : MonoBehaviour {

	Animator animator;

	Rigidbody2D rb; //fysiikat
	Transform _transform;
	public float speed = 1;

	public bool paussi = false;

	GameObject Maincamera;
	GameObject levelcontrol;
	
	bool hyppy = false; //alkuarvot
	bool oikea = false;
	bool vasen = false;
	bool grounded = false;

	public int coins = 0;

	Vector3 alku; //spawnpoint


	// Use this for initialization
	void Start () {

		animator = GetComponent<Animator> ();


		rb = GetComponent<Rigidbody2D> ();
		_transform = GetComponent <Transform> ();


		alku = _transform.position;

		Maincamera = GameObject.FindGameObjectWithTag ("MainCamera");
		levelcontrol = GameObject.FindGameObjectWithTag ("levelcontrol");
	
	}


	void maassa () {
		grounded = true;
	}

	void ilmassa () {
		grounded = false;
	}

    void kuolin () {
		_transform.position = alku;
		levelcontrol.SendMessageUpwards ("kuolin", SendMessageOptions.DontRequireReceiver);
		Maincamera.SendMessageUpwards ("kuolin", alku, SendMessageOptions.DontRequireReceiver);
	}
	

	void kolikko () {
		coins ++;
	}


	void Update () { 

			if (Input.GetKeyDown (KeyCode.Space)) {
				hyppy = true;
			} else
	

			if (Input.GetKey (KeyCode.A)) {
				vasen = true;
			} else
				vasen = false;

			if (Input.GetKey (KeyCode.D)) {
				oikea = true;
			} else
				oikea = false;
	}
	

	// Update is called once per frame
	void FixedUpdate () {




			if (hyppy && !paussi && grounded) {
				
				rb.AddForce (transform.up * speed * 180);
				grounded = false;
				
			}

		    if (hyppy) {
			hyppy = false;
		}






	


		if (!grounded) {
			animator.SetBool ("hyppaa", true);
		}

		if (grounded) {
			animator.SetBool ("hyppaa", false);
		}
	



		if (oikea && (rb.velocity.x <= 1) && !paussi) {
			animator.SetBool("liikkuu", true);
			rb.AddForce (transform.right * speed * 6);
			transform.localScale = new Vector2 (0.7f, 0.7f);
		}

		if (vasen && (rb.velocity.x >= -1f) && !paussi) {
			animator.SetBool("liikkuu", true);
			rb.AddForce(-transform.right * speed * 6);
			transform.localScale = new Vector2 (-0.7f, 0.7f);
		}

		if (!vasen && !oikea && !paussi ) {
			animator.SetBool ("liikkuu", false);
		}


	}
}
