using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator anim;
    [SerializeField] bool lockCursor = true;
    private bool isJumping = false;

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
        float horizontal = (
            Mathf.Abs(ThirdPersonMovement.velocity.normalized.x) +
            Mathf.Abs(ThirdPersonMovement.velocity.normalized.z)
        ) / 2;
        anim.SetBool("Walk", (horizontal > 0));
        anim.SetBool("Run", horizontal > 0 && Input.GetKey(KeyCode.LeftShift));
    }
}
