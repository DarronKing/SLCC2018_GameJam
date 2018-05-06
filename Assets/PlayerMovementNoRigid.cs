﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementNoRigid : MonoBehaviour {

	public float speed;
    
    Animator animator;

    private float moveHorizontal;

    void Start ()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void FixedUpdate ()
    {
        moveHorizontal = Input.GetAxis ("Horizontal");

        animator.SetFloat("State", -moveHorizontal);

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);

        transform.Translate((movement * Time.deltaTime) * speed);

        
    }
}
