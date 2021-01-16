using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField] Transform copy;
    [SerializeField] Transform changer;

    Vector3 tempPos;
    Vector3 pos;

    void Start() {
        
        

    }

    // Update is called once per frame
    void Update() {
        tempPos = copy.transform.position;
        pos = changer.transform.position;


        tempPos.y = pos.y;
        tempPos.x = pos.x;
        tempPos.z = pos.z;

        copy.position = tempPos;
    }

}
