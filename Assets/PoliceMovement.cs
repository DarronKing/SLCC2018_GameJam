using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceMovement : MonoBehaviour {

	public GameObject player;
	private PlayerMovementNoRigid p;
	private bool TouchingTarget = false;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		p = player.GetComponent<PlayerMovementNoRigid>();
	}
	
	// Update is called once per frame
	void Update () {
		if (p.GetTarget() != null) {
			print("Target Aquired");
			if (!TouchingTarget)
				Tackle(p.GetTarget());
			else 
				SlamDown();
			
		}
	}

	void Tackle(GameObject target) {
		transform.position = Vector2.MoveTowards(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y),
					 new Vector2(target.transform.position.x, target.transform.position.y), .03f);
	}

	void SlamDown() {
		
	}
}
