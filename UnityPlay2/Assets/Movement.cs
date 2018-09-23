using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    float speed = 10;
	
	// Update is called once per frame
	void Update () {
        //transform.position = new Vector3(0, 1, 0);
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        print(input);

        Vector3 direction = input.normalized;
        Vector3 velocity = direction * speed;
        Vector3 moveAmount = velocity * Time.deltaTime;

        // ok, I think to move in a direction it is direction * deltatime * speed
		transform.Translate(moveAmount, Space.World);
	}
}
