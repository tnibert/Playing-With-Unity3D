using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

	public Transform sphereTransform;

	// Use this for initialization
	void Start () {
		sphereTransform.parent = transform;
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime * 180, Space.World);

		// aka transform.eulerAngles += Vector3.down * 180 * Time.deltaTime;
		// all of the following are equivalent:
		// new Vector3(0, 180 * Time.deltaTime, 0);
		// new Vector3(0, 1, 0) * 180 * Time.deltaTime;
		// or Vector3.up * 180 * Time.deltaTime; - also have .down, .left, .right

		//transform.Translate(Vector3.forward * Time.deltaTime * 7, Space.World);
	}
}
