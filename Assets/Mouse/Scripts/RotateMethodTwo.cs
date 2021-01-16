using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMethodTwo : MonoBehaviour
{
    [SerializeField] Transform headArm;
    [SerializeField] float sensitivity = 5.0f;


     void Update() {
        float yaw = sensitivity * Input.GetAxis("Mouse X");
        float pitch = sensitivity * Input.GetAxis("Mouse Y");
        headArm.Rotate(-pitch, yaw, 0);
        
         
     }
 
}
