using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour {

    public Transform targetTransform;
    float speed = 7;

    // update is called once per frame
	void Update () {
		Vector3 displace = targetTransform.position - transform.position;
        Vector3 dirToTarget = displace.normalized;
        Vector3 velocity = dirToTarget * speed;
        
        if(displace.magnitude > 1.5f) {
            transform.Translate(velocity * Time.deltaTime);
        }
	}
}
