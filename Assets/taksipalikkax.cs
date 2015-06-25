using UnityEngine;
using System.Collections;

public class taksipalikkax : MonoBehaviour {

	
	
	Rigidbody2D rb;
	Transform _transform;

	bool goright = false;
	bool goleft = false;
	public float xdest;
	public float speed = 1;
	Vector3 alku;
	public bool active = false;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();
		_transform = GetComponent<Transform> ();
		alku = _transform.position;
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			active = true;		  
		}
	}
	

	void Update () {

		if (active) {

			if (_transform.position.x <=xdest && _transform.position.x <= alku.x)
				goright = true;
			goleft = false;
		}

			if (_transform.position.x >= xdest) {
		    goright = false;
			goleft = true;
			}
		return;


		
		}

	// Update is called once per frame
	void FixedUpdate () {

		if (goleft) {
			rb.velocity = (-transform.right * speed * 0.3f);
			goright = false;
		}
		if (goright) { 
				rb.velocity = (transform.right * speed * 0.3f);
			goleft = false;
		}

		
	}
}