using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour {

	private float x;
    private float y;
    private Vector3 rotateValue;
    private float speed = 5;

    public Transform targetTransform;
	
	// Update is called once per frame
	void Update () {
        
        // directional movement
        
        //Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        //print(input);

        //Vector3 direction = input.normalized;
        //Vector3 velocity = direction * speed;
        //Vector3 moveAmount = velocity * Time.deltaTime;

        //transform.Translate(moveAmount);

        // follow the cube
        Vector3 displace = targetTransform.position - transform.position;
        Vector3 dirToTarget = displace.normalized;
        Vector3 velocity = dirToTarget * speed;

        if(displace.magnitude > 1.5f) {
            transform.Translate(velocity * Time.deltaTime);
        }


        // update rotation
		y = Input.GetAxis("Mouse X");
        x = Input.GetAxis("Mouse Y");
        Debug.Log(x + ":" + y);
        rotateValue = new Vector3(x, y * -1, 0);
        transform.eulerAngles = transform.eulerAngles - rotateValue;
	}
}
