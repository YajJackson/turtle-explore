using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkIdle : MonoBehaviour
{

    Animator anim;

    [SerializeField] bool lockCursor = true;

    void Start()
    {

        anim = GetComponent<Animator>();
        if(lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        
    }

    
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.LeftShift)) {
                anim.SetBool("Run", true);
            }
               if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyUp(KeyCode.LeftShift)) {
                anim.SetBool("Run", false);
            }

        if (Input.GetKeyDown(KeyCode.W)) {
            anim.SetBool("Walk", true);

        }
        if (Input.GetKeyUp(KeyCode.W)) {
            anim.SetBool("Walk", false);
        }

         if (Input.GetKeyDown(KeyCode.S)) {
            anim.SetBool("BackWalk", true);
        }
        if (Input.GetKeyUp(KeyCode.S)) {
            anim.SetBool("BackWalk", false);
        }
        
    }
}
