using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //variables
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;

    private void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        //on ground?
        if (controller.isGrounded)
        {
            //moveDirection input
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            //multiply by speed
            moveDirection *= speed;
            //jumping
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }
        //apply gravity
        moveDirection.y -= gravity * Time.deltaTime;
        //movepls
        controller.Move(moveDirection * Time.deltaTime);
    }
}
