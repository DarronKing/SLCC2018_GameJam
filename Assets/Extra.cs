using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extra : MonoBehaviour {

	private float speed;
	public float min_speed = 0.1f;
	public float max_speed = 0.6f;
	private float direction;
	private bool left;
	public bool destroy;

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		direction = Random.Range(-1.0f, 1.0f);
		if (direction <= 0){
			left = true;
			direction = -1;
		}
		else{
			direction = 1;
			left = false;
		}
		speed = Random.Range(min_speed, max_speed);
		
		animator.SetBool("Left", left);


	}
	
	// Update is called once per frame
	void Update () {

		// moveHorizontal = Input.GetAxis ("Horizontal");
		

        

        Vector3 movement = new Vector3 (direction, 0.0f, 0.0f);

        transform.Translate((movement * Time.deltaTime) * speed);
		
	}

	// void OnCollisionEnter2D (Collider2D other) {
	// 	if (other.gameObject.tag == "Extra")

	// }
}
