using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class VRMovement : MonoBehaviour
{
    public OVRInput.Controller controller; // Set this to Left or Right controller
    public float moveSpeed = 1.0f;
    public Transform cameraRotation; // Reference to the GameObject whose rotation you want to follow

    private void Update()
    {
        Vector2 thumbstickInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, controller);

        // Calculate movement direction based on the thumbstick input
        Vector3 moveDirection = cameraRotation.transform.forward * OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, controller).y + cameraRotation.transform.right * OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, controller).x;

        // Apply speed to the movement direction
        moveDirection = moveDirection.normalized * moveSpeed;

        // Move the player or camera
        transform.Translate(moveDirection * Time.deltaTime, Space.World);
    }
}