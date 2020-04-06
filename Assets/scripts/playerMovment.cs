using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovment : MonoBehaviour
{
    public float speed = 12;
    public float gravity = 9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpHeight = 3f;

    public CharacterController controller;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y > 0)
        {
            velocity.y = 2f;
        }

        //Debug.Log(isGrounded);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime * -1);

        // Fixme jumping V
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            Debug.Log("jump");
            velocity.y = (Mathf.Sqrt(jumpHeight * 2f * gravity)) * -1;
        }


        velocity.y += gravity * Time.deltaTime;

        // deltay = 1/2g * t * t
        controller.Move(velocity * Time.deltaTime * -1);
    }
}
