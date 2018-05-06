using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementNoRigid : MonoBehaviour {

	public float speed;
    
    Animator animator;

    public GameObject target = null;
    
    private GameObject enemyCollidingWith = null;
    private float moveHorizontal;

    void Start ()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Wave();
        }
    }

    void FixedUpdate ()
    {
        moveHorizontal = Input.GetAxis ("Horizontal");

        animator.SetFloat("State", -moveHorizontal);

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);

        transform.Translate((movement * Time.deltaTime) * speed);
    }

    void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag == "Extra") {
            print ("Colliding with it");
            enemyCollidingWith = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.tag == "Extra") {
            enemyCollidingWith = null;
        }
    }

    private void Wave() {
        if (enemyCollidingWith == null)
            return;

        target = enemyCollidingWith;
    }

    public GameObject GetTarget() {
        return target;
    }
}
