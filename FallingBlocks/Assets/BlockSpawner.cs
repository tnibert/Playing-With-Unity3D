using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {

	public GameObject blockPrefab;
	public float spawnDelaySec = 1;
	float nextSpawn;
	//float blockHalfHeight;
    
	public float minsize = 0.3f;
	public float maxsize = 1.7f;
    
	float spawnAngleMax = 30f;

	Vector2 screenHalfSize;
    
	// Use this for initialization
	void Start () {
		screenHalfSize = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
		//blockHalfHeight = blockPrefab.transform.localScale.x / 2f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawn)
		{
			float spawnAngle = Random.Range(-spawnAngleMax, spawnAngleMax); 
			float spawnSize = Random.Range(minsize, maxsize);
			Vector2 spawnPos = new Vector2(Random.Range(-screenHalfSize.x, screenHalfSize.x), screenHalfSize.y + hypotenuse(spawnSize));
            
			GameObject newBlock = (GameObject)Instantiate(blockPrefab, spawnPos, Quaternion.Euler(Vector3.forward * spawnAngle));        // Quaternion.identity means no rotation
			newBlock.transform.localScale = Vector2.one * spawnSize;

			nextSpawn = Time.time + spawnDelaySec;
		}
	}
    
	float hypotenuse(float spawnSize)
	{
		// a^2 + b^2 = c^2
		float half = spawnSize / 2;
		float result = Mathf.Sqrt((half * half) + (half * half));
		return result;
	}
}
