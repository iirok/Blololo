using UnityEngine;
using System.Collections;

public class Enemy2 : MonoBehaviour {

	
	
	
	
	Rigidbody2D rb;
	Transform _transform;
	
	public float xmin;
	public float xmax;
	public float speed = 1;
	bool goright = false;
	bool goleft = false;
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();
		_transform = GetComponent<Transform> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (_transform.position.x <= xmin) {
			goright = true;
			goleft = false;
		}
		
		
		if (_transform.position.x >= xmax) {
			goleft = true;
			goright = false;
		}
		
		
		
	}
	
	
	void FixedUpdate () {
		
		if (goright) {
			rb.velocity = (transform.right * speed * 1.2f);
			transform.localScale = new Vector2 (1.2f, 1.2f);
			
		}
		if (goleft) {
			rb.velocity = (-transform.right * speed * 1.2f);
			transform.localScale = new Vector2 (-1.2f, 1.2f);
		}
		
	}
	
}