using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 280.0f;
    float x;
    float z;

    private void Update()
    {
        Vector3 moveDirection = Vector3.forward * z + Vector3.right * x;
        Vector3 projectedCameraForward = Vector3.ProjectOnPlane(Camera.main.transform.forward, Vector3.up);
        Quaternion rotationToCamera  = Quaternion.LookRotation(projectedCameraForward, Vector3.up);

        moveDirection = rotationToCamera * moveDirection;
        Quaternion rotationToMoveDirection  = Quaternion.LookRotation(moveDirection, Vector3.up);

        // transform.rotation = Quaternion.RotateTowards(transform.rotation, rotationToCamera, rotationSpeed * Time.deltaTime);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotationToMoveDirection, rotationSpeed * Time.deltaTime);

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
    public void OnMoveInput(float x, float z)
    {
        this.x = x;
        this.z = z;
        Debug.Log($"Player Move input: {this.x}, {this.z}");
    }
}
