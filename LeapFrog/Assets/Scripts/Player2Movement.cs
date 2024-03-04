using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
   public float speed = 3;
    public float rotationSpeed = 90;
    public float gravity = -20f;
    public float jumpSpeed = 15.0f;
    
    public float pushForce = 3.0f;
    private ControllerColliderHit contact;
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
        float rotationInput = Input.GetAxis("Horizontal2");
        float verticalInput = Input.GetAxis("Vertical2");

        verticalInput = Mathf.Clamp01(verticalInput);

        moveVelocity = transform.forward * speed * verticalInput;
        turnVelocity = transform.up * rotationSpeed * rotationInput;

        if (characterController.isGrounded)
        {
            // Debug.Log("Player 2 Grounded!");
            moveVelocity = transform.forward * speed * verticalInput;
            turnVelocity = transform.up * rotationSpeed * rotationInput;

            if (Input.GetKey(KeyCode.K))
            {
                // Debug.Log("Player 2 Jumped!");
                moveVelocity.y = jumpSpeed;
            }
        }
        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);
    }

    // store collision to use in Update
	void OnControllerColliderHit(ControllerColliderHit hit) {
		contact = hit;
		
		Rigidbody body = hit.collider.attachedRigidbody;
		if (body != null && !body.isKinematic) {
			body.velocity = hit.moveDirection * pushForce;
		}
	}
}
