using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementNoRigid : MonoBehaviour {

	public float speed;

    void Start ()
    {
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);

        transform.Translate((movement * Time.deltaTime) * speed);
    }
}
