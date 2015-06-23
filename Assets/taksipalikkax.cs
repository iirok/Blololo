using UnityEngine;
using System.Collections;

public class taksipalikkax : MonoBehaviour {

	
	
	Rigidbody2D rb;
	Transform _transform;

	public float xdest;
	public float speed = 1;
	
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();
		_transform = GetComponent<Transform> ();
		
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player")
		if (_transform.position.x <= xdest) {
			rb.velocity = (transform.right * speed * 0.3f);
		}
	}


	// Update is called once per frame
	void FixedUpdate () {

		if (_transform.position.x >= xdest) {
			rb.velocity = (transform.right * speed * 0);
		}

		
	}
}