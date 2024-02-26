using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class Movement : MonoBehaviour
{
    public OVRInput.Button jumpButton = OVRInput.Button.One; // Configure the button for jumping
    public float jumpForce = 5.0f; // Adjust this value to control the jump height

    private Rigidbody playerRigidbody;
    private bool isGrounded = true;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
        
    {
        // Check for jump button press
        if (OVRInput.GetDown(jumpButton) && isGrounded)
        {
            // Apply an upward force to simulate jumping
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // Prevent multiple jumps until landing
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Detect if the player lands on the ground (for example, a collider with the "Ground" tag)
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}