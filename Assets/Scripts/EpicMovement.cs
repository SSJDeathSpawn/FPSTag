using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpicMovement : MonoBehaviour
{

    public float playerSpeed = 30f;
    public CharacterController controller;
    public float gravity = -9.8f;
    public float jumpHeight = 10f;
    public bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundMask;
    public float speedMultiplier = 5.0f;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, 0.5f, groundMask);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = (transform.right*x + transform.forward*z);

        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            playerSpeed *= speedMultiplier;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift)) {
            playerSpeed /= speedMultiplier;
        }

        controller.Move(move * playerSpeed * Time.deltaTime);

        if(!isGrounded) velocity.y += gravity * Time.deltaTime;

        if(isGrounded && velocity.y < 0) {
            velocity.y = 0;
        }

        if(Input.GetButton("Jump") && isGrounded) {
            velocity.y = Mathf.Sqrt(-2f * gravity * jumpHeight);
        }

        controller.Move(velocity * Time.deltaTime);

    }
}
