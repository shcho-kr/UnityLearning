using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour {

    void Start() {
        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("Distance : " + distance);
    }

    float GetDistance(float x1, float y1, float x2, float y2) {
        float width = x2 - x1;
        float height = y2 - y1;

        float distance = width * width + height * height;
        distance = Mathf.Sqrt(distance);

        return distance;
    }

}
