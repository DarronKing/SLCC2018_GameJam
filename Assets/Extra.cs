using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extra : MonoBehaviour {

	private float speed;
	public float min_speed;
	public float max_speed;
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
		// if (destory == true){
			
		// }

        

        Vector3 movement = new Vector3 (direction, 0.0f, 0.0f);

        transform.Translate((movement * Time.deltaTime) * speed);
		
	}
}
