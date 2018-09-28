using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 7;
	float blockstop;
	float halfPlayerWidth;

	// Use this for initialization
	void Start () {
		halfPlayerWidth = transform.localScale.x / 2f;
		blockstop = Camera.main.aspect * Camera.main.orthographicSize - halfPlayerWidth;
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxisRaw("Horizontal");
		float velocity = inputX * speed;        // direction * speed
		transform.Translate(Vector2.right * velocity * Time.deltaTime);

		if (transform.position.x < -blockstop)
		{
			transform.position = new Vector2(-blockstop, transform.position.y);
		}
		else if (transform.position.x > blockstop)
        {
            transform.position = new Vector2(blockstop, transform.position.y);
        }
	}
}
