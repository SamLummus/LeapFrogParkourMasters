using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 3;
    public float rotationSpeed = 90;
    public float gravity = -20f;
    public float jumpSpeed = 15.0f;
    CharacterController characterController;
    Vector3 moveVelocity;
    Vector3 turnVelocity;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotationInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        verticalInput = Mathf.Clamp01(verticalInput);

        moveVelocity = transform.forward * speed * verticalInput;
        turnVelocity = transform.up * rotationSpeed * rotationInput;

        if (characterController.isGrounded)
        {
            // Debug.Log("Grounded!");
            moveVelocity = transform.forward * speed * verticalInput;
            turnVelocity = transform.up * rotationSpeed * rotationInput;

            if (Input.GetKey(KeyCode.S))
            {
                // Debug.Log("Jumped!");
                moveVelocity.y = jumpSpeed;
            }
        }
        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);
    }
}