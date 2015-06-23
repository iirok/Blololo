using UnityEngine;
using System.Collections;

public class enemy1b : MonoBehaviour {
	
	
	
	
	Animator animator;
	Rigidbody2D rb;
	Transform _transform;
	
	public float xmin;
	public float xmax;
	public float speed = 1;
	bool sisaan = false;
	bool goright = false;
	bool goleft = false;
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();
		_transform = GetComponent<Transform> ();
		animator = GetComponent<Animator> ();
	}
	
	void aktivointi () {
		sisaan = true;
	}
	
	void stop () {
		
		sisaan = false;
		
	}
	
	
	
	// Update is called once per frame
	void Update () {
		
		if (sisaan) {
			if (_transform.position.x <= xmin) {
				goright = true;
				goleft = false;
			} else if (_transform.position.x >= xmax) {
				goleft = true;
				goright = false;
			}
		}
		
		if (!sisaan) {
			
			if (_transform.position.x >= xmin) {
				goleft = true;
				goright = false;
			}
			
			
			if (_transform.position.x <= xmin) {
				goleft = false;
				goright = false;
			}	
		}
	}
	
	
	void FixedUpdate () {
		
		if (goright) {
			rb.velocity = (transform.right * speed * 0.6f);
			animator.SetBool("liikkuu", true);
			transform.localScale = new Vector2 (1, 1);
			
		}
		if (goleft) {
			rb.velocity = (-transform.right * speed * 0.6f);
			animator.SetBool("liikkuu", true);
			transform.localScale = new Vector2 (-1, 1);
		}
		
		
		if (!goright && !goleft) {
			rb.velocity = (transform.right * speed * 0);
			animator.SetBool("liikkuu", false);
			transform.localScale = new Vector2 (-1, 1);
		}
	}
	
}