using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Code sourced from https://answers.unity.com/questions/1344322/free-mouse-rotating-camera.html
public class cameraMove : MonoBehaviour
{
    public class move : MonoBehaviour
    {


        void Start()
        {
            Camera Camera;
        }


        void FixedUpdate()
        {
            float x = 5 * Input.GetAxis("Mouse X");
            float y = 5 * -Input.GetAxis("Mouse Y");
            Camera.main.transform.Rotate(x, y, 0);


        }
    }
}