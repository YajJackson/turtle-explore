using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMethodOne : MonoBehaviour
{
    
    [SerializeField] float headSensitivity = 3.5f;
    [SerializeField] Transform headArm;

    float headPitch = 0.0f;
    CharacterController controller = null;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
    
        UpdateMouseLook();
    }

    void UpdateMouseLook() { 

    Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

    headPitch -= mouseDelta.y * headSensitivity;

    headPitch = Mathf.Clamp(headPitch, -45.0f, 45.0f);

    headArm.Rotate(Vector3.up * mouseDelta.x * headSensitivity);

    }

}
