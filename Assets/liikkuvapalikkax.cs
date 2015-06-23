using UnityEngine;
using System.Collections;

public class liikkuvapalikkax : MonoBehaviour {

	
	Rigidbody2D rb;
	Transform _transform;
	
	public float xstart;
	public float xdest;
	public float speed = 1;
	
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();
		_transform = GetComponent<Transform> ();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (_transform.position.x >= xdest) {
			rb.velocity = (-transform.right * speed * 0.3f);
		}
		
		if (_transform.position.x <= xstart) {
			rb.velocity = (transform.right * speed * 0.3f);
		}
		
	}
}
