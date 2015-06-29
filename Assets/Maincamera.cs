using UnityEngine;
using System.Collections;

public class Maincamera : MonoBehaviour {
	
	Transform target;
	Transform _transform;

	// Use this for initialization
	void Start () {
		
		_transform = GetComponent<Transform> ();
		target = GameObject.FindGameObjectWithTag ("Player") .GetComponent <Transform> ();
		
	}



	void kuolin(Vector3 alku){
		alku.z = transform.position.z;
		alku.y = transform.position.y;
		_transform.position = alku;
	}




	// Update is called once per frame
	void Update () {
		
		if (target.position.x >= -2.85f && target.position.x <= 2.85f) 
		{
			
			
			_transform.position = Vector3.Slerp (_transform.position, new Vector3 (target.position.x, _transform.position.y, _transform.position.z), 0.01f);
			
		}
		
		
		
	}
}