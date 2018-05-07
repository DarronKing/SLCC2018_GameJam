using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed;
    
    private Rigidbody2D rb;

    Animator animator;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        // float moveVertical = Input.GetAxis ("Vertical");
        // if (Input.GetKey("a")){
        //     animator.SetFloat("State", 1);
        // }
        // else if (Input.GetKey("d")){
        //     animator.SetFloat("State", -1);
        // }
        animator.SetFloat("State", moveHorizontal);

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);


        rb.AddForce (movement * speed);

    }
}
