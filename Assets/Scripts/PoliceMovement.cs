using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PoliceMovement : MonoBehaviour {

	private GameObject player;
	private PlayerMovementNoRigid p;
	private bool TouchingTarget = false;
	private bool youWin = false;

	public string WinScene;
	public string LoseScene;

	// how to tell which final target something...
	public GameObject FinalTarget;
	public Text EndText;

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
			
			
		}
	}

	void OnCollisionEnter2D(Collision2D c) {
		if (c.gameObject == p.GetTarget()) {
			if(c.gameObject == FinalTarget) {
				youWin = true;
				StartCoroutine("EndGame");
			} else {
				youWin = false;
				StartCoroutine("EndGame");
			}
		}
	}

	void Tackle(GameObject target) {
		transform.position = Vector2.MoveTowards(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y),
					 new Vector2(target.transform.position.x, target.transform.position.y), .03f);
	}

	IEnumerator EndGame()
    {
		yield return new WaitForSeconds(3);
		if (youWin) {
			EndText.text = "You Win";
		} else {
			EndText.text = "You Lose :(";
		}
        yield return new WaitForSeconds(3);
        if (youWin) {
			SceneManager.LoadScene(WinScene);
		}
		else
			SceneManager.LoadScene(LoseScene);
    }
}
