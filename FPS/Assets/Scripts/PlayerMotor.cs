using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 playerVelo;
    private bool isGrounded;
    public float speed = 5f;
    public float gravity = -9.8f;
    public float jumpHeight = 1f;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = characterController.isGrounded;

    }

    public void processMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        characterController.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        playerVelo.y += gravity * Time.deltaTime;
        if (isGrounded && playerVelo.y < 0)
        {
            playerVelo.y = -2f;
        }
        characterController.Move(playerVelo * Time.deltaTime);
    }

    public void Jump()
    {
        if (isGrounded)
        {
            playerVelo.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }
    }
}
