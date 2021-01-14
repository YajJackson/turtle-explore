using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
   public float speed;
   public float strafeSpeed;
   public float jumpForce;
   public float DisToGround = 1.0f;

   public Rigidbody hips;
    
    public ConfigurableJoint[] Joints = new ConfigurableJoint [28];
    public Transform[] AnimatedTransforms = new Transform [29];
   

    void Start()
    {
        
        hips = GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        if(isGrounded && Input.GetKey(KeyCode.W))
        {
            if(isGrounded && Input.GetKey(KeyCode.LeftShift))
            {
                hips.AddForce(hips.transform.forward * speed * 3.0f);
            } else {
                hips.AddForce(hips.transform.forward * speed);
            }
        }

        if (isGrounded && Input.GetKey(KeyCode.A)) {
        
            hips.AddForce(-hips.transform.right * speed);
        }

        if (isGrounded && Input.GetKey(KeyCode.S)) {
            hips.AddForce(-hips.transform.forward * speed);
        }

        if (isGrounded && Input.GetKey(KeyCode.D)) {
            hips.AddForce(hips.transform.right * speed);
        }
        
        GroundCheck();
        
        if (isGrounded && Input.GetAxis("Jump") > 0) {
            hips.AddForce(new Vector3(0, jumpForce, 0));
        }
    }

    public bool isGrounded = false;

    void GroundCheck ()
    {
        if(Physics.Raycast(transform.position, Vector3.down, DisToGround + 0.1f))
        {
            isGrounded = true;
        } else {
            isGrounded = false;
        }

    }


}
