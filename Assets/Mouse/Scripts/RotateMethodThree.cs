using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMethodThree : MonoBehaviour
{
    
    [SerializeField] Quaternion headRotation;
    [SerializeField] float sensitivity = 5.0f;

    public float lookUpMax = 45;
    public float lookUpMin = -45;

    void Start() {
        headRotation = transform.localRotation;
    }

    void Update() {
        
        headRotation.x += Input.GetAxis("Mouse Y") * sensitivity * (-1);
        headRotation.y += Input.GetAxis("Mouse X") * sensitivity;

        headRotation.x = Mathf.Clamp(headRotation.x, lookUpMin, lookUpMax);

        transform.localRotation = Quaternion.Euler(headRotation.x, headRotation.y, headRotation.z);

    }
}
