using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemies : MonoBehaviour {
	public float SpawnRate = 3;

	private int randSpawnPoint;
	private int randPrefab;

	private Transform[] ExtraSpawnPoints;

	public GameObject[] ExtraPrefabs;

	// Use this for initialization
	void Start () {
		ExtraSpawnPoints = GetComponentsInChildren<Transform>();
		StartCoroutine("SpawnPplz");
	}
	

	IEnumerator SpawnPplz() {
		while (true) {
			randSpawnPoint = Random.Range(0, ExtraSpawnPoints.Length);
			randPrefab = Random.Range(0, ExtraPrefabs.Length);
			yield return new WaitForSeconds(SpawnRate);
			Instantiate(ExtraPrefabs[randPrefab], ExtraSpawnPoints[randSpawnPoint]);
		}
	}

	// Update is called once per frame
	void Update () {

		
		// foreach (Transform child in ExtraSpawnPoints){
			
		// 	if (Random.Range(0.0f, 10) < SpawnRate){
		// 		Instantiate(ExtraPrefabs[Random.Range(0, ExtraPrefabs.Length)], child);
		// 	}
			
		// }
	}
}
