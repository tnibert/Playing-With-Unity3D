using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 6;
	Rigidbody myRigidbody;      // for physics
	Vector3 velocity;           // this default initializes to zero?
	public int coinCount = 0;
	public event Action onPlayerDeath;
	public event Action onCoinGrab;
	public int health = 3;
    
	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody>(); 
		// todo: let's decrement our health every collision
	}

	// Update is called once per frame
	void Update () {
		Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		Vector3 direction = input.normalized;
		velocity = direction * speed;

		// check health status
		if (health <= 0)
		{
			if (onPlayerDeath != null)
			{
				onPlayerDeath();
			}
			Destroy(gameObject);        // I suppose this is a reference to whatever the script is attached to
		}
	}

	void FixedUpdate() {
		myRigidbody.position += velocity * Time.fixedDeltaTime;
	}

	void OnTriggerEnter(Collider triggerCollider)
    // oh no he didn't
	{
		//print(triggerCollider.gameObject.name);
		if (triggerCollider.tag == "Coin")
		{
			Destroy(triggerCollider.gameObject);
			coinCount++;
			onCoinGrab();
		}
	}
}
