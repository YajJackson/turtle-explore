using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterLook : MonoBehaviour
{
    [SerializeField] Transform rotator;
    [SerializeField] Quaternion tempRot;
    public bool toggle = true;


    void Start() {
        tempRot = rotator.localRotation;
    }

    void Update() {
        
        if (Input.GetKey(KeyCode.W)) {
        rotator.localRotation = Quaternion.Euler(tempRot.x, tempRot.y, tempRot.z);
        
      

        if(tempRot.x <= 0) {
            tempRot.x -= .5f;
        }

         if(tempRot.x >= 0) {
            tempRot.x += .5f;
        }


        }
    }
}
