using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    // without assignment this int has a default value of 0
    int frameCount = 0;
    int target;
    float start;

	// Use this for initialization
	void Start () {
		print("Up we GO");
        target = waitTime();
        print("Initial target is " + target + "!");
	}
	
	// Update is called once per frame
	void Update () {
        frameCount++;

        if(Input.GetKeyDown(KeyCode.Space)) {
            float curTime = Time.time;
            int diff = (int)(curTime - start);
            print("target - " + target + ", diff - " + diff);
            if(target == diff) {
                print("EPIC WIN");
            }
            else {
                print("FAILSAUCE");
            }

            target = waitTime();
            print("NEW TARGET: " + target);
        }
	}

    float GetDist(float x1, float y1, float x2, float y2) {
        float dX = x2 - x1;
        float dY = y2 - y1;
        float dstSquared = dX * dX + dY * dY;
        float dst = Mathf.Sqrt(dstSquared);
        return dst;
    }

    int waitTime() {
        start = Time.time;
        return Random.Range(1,16);
    }
}
