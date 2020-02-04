
using System;
using System.Timers;
using UnityEngine;
using UnityEngine.Events;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 positionDirection;
    public float speed = 5f;
    public float gravity = -3f;
    public float jumpForce = 10f;
    public UnityEvent cameraMove;
    void Start()
    {
        
        
    }

  
    void Update()
    {
        positionDirection.x = Input.GetAxis("Vertical") * speed;
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            positionDirection.y = jumpForce;
        }
        positionDirection.z = Input.GetAxis("Horizontal") * -(speed);
        positionDirection.y += gravity;
        controller.Move(positionDirection*Time.deltaTime);
    }

    private void OnMouseDrag()
    {
       cameraMove.Invoke();
    }
}
