using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Code sourced from https://answers.unity.com/questions/1344322/free-mouse-rotating-camera.html

public class cameraMove : MonoBehaviour
{
    public float x;
    public float y;
    

    void Update()
        {
            float x = 5f * Input.GetAxis("Mouse X");
            float y = 5f * -Input.GetAxis("Mouse Y");
            Camera.current.transform.Rotate(x, y, 0);
        }
}
