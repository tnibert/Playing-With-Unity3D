using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    // without assignment this int has a default value of 0
    int frameCount = 0;

	// Use this for initialization
	void Start () {
		print("Up we GO");
	}
	
	// Update is called once per frame
	void Update () {
        frameCount++;
        print("And there's a frame: " + frameCount);
	}

    float GetDist(float x1, float y1, float x2, float y2) {
        float dX = x2 - x1;
        float dY = y2 - y1;
        float dstSquared = dX * dX + dY * dY;
        float dst = Mathf.Sqrt(dstSquared);
        return dst;
    }
}
