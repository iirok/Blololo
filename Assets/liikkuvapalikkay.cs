using UnityEngine;
using System.Collections;


public class liikkuvapalikkay : MonoBehaviour {

	Rigidbody2D rb;
	Transform _transform;

	public float ystart;
	public float ydest;
	public float speed = 1;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		_transform = GetComponent<Transform> ();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (_transform.position.y >= ydest) {
			rb.velocity = (-transform.up * speed * 0.3f);
		}

		if (_transform.position.y <= ystart) {
			rb.velocity = (transform.up * speed * 0.3f);
		}
	
	}
}
