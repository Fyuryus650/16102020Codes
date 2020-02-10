
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 positionDirection;
    public float speed = 5f;
    public float gravity = -3f;
    public float jumpForce = 10f;
    public UnityEvent cameraMove;
    private int jumpCount = 0;
    public int jumpCountMax = 2;
    
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

  
    void Update()
    {

        if (controller.isGrounded)
        {
            positionDirection.y = 0;
            jumpCount = 0;
        }
        
        
        positionDirection.x = Input.GetAxis("Vertical") * speed;
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            positionDirection.y = jumpForce;
            jumpCount++;
        }
        positionDirection.z = Input.GetAxis("Horizontal") * -(speed);
        positionDirection.y += gravity;
        controller.Move(positionDirection*Time.deltaTime);
    }
    
}
