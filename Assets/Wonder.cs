using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wonder : MonoBehaviour {

	Animator animator;

	private int ran;
	private bool wondering = false;
	private int wonder_time = 5;
	private int direction;
	public float speed = 10;
	private int counter;

	// Use this for initialization
	void Start () {
		// wondering : bool
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (wondering == false){
			ran = Random.Range(0, 10);
			if (ran <= 3){
				wondering = true;
				ran = Random.Range(1, 2);
				if (ran == 1){
					direction = -1;
				}
				else{
					direction = 1;
				}
			}
		}
		// else{
		// 	counter = 0;
		// 	while (wondering == true){

		// 		Vector3 movement = new Vector3(direction, 0.0f, 0.0f);

		// 		if (counter >= wonder_time){
		// 			wondering == false;
		// 		}
		// 		counter = (counter + 1);
			
		// 	}
		// }
			
			
		
	}
}
