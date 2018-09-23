using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureSpawner : MonoBehaviour {

	public GameObject tablePrefab;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P)) {
			Vector3 randomSpawnPos = new Vector3(Random.Range(-10f, 10f), 2, Random.Range(-10f, 10f));
			Vector3 randomSpawnRot = Vector3.up * Random.Range(0, 360);

            // why are these invisibile??? .. it was because the spawn position was placing the tables underneath our plane
			GameObject newtable = (GameObject) Instantiate(tablePrefab, randomSpawnPos, Quaternion.Euler(randomSpawnRot));
			newtable.transform.parent = transform;
		}
	}
}
