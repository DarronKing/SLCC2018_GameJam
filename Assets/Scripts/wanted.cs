using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wanted : MonoBehaviour {

	public GameObject wantedCriminal;
	public GameObject CurrentTarget;

	void Update() {
		if (CurrentTarget == null) {
			if (wantedCriminal == null)
				print("Vicatory!");
		}
		else {
			print("Deeefet!");
		}

	}	

	public GameObject GetCurrentTarget() {
		return CurrentTarget;
	}

	public void SetCurrentTarget(GameObject c) {
		CurrentTarget = c;
	}

}
