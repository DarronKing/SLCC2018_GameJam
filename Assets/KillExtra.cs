using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillExtra : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other) {
		print("Collide");
		if (other.gameObject.tag == "Extra")
			Destroy(other.gameObject);
	}
}
