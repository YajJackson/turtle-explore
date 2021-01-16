using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
   
   public float speed = 1.0f;

    public Transform mover;

    public Transform moveGuy;

    void Update()
    {
        
        float step = speed * Time.deltaTime;
        moveGuy.position = Vector3.MoveTowards(moveGuy.position, mover.position, step);

    }
}
