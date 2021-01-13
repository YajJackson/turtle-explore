using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveRagdoll : MonoBehaviour
{

    [Header("-- Body Parts --")]
    [SerializeField] Transform AnimatedTorso;
    [SerializeField] Rigidbody PhysicalTorso;
    Transform _animatedTorso { get { return _animatedTorso; } }

    [SerializeField] Transform AnimatedStomach;
    [SerializeField] Rigidbody PhysicalStomach;

     [Header("- Head & Neck -")]
    [SerializeField] Transform AnimatedNeck;
    [SerializeField] Rigidbody PhysicalNeck;

    [SerializeField] Transform AnimatedHead;
    [SerializeField] Rigidbody PhysicalHead;

    [SerializeField] Transform AnimatedLeftEar;
    [SerializeField] Rigidbody PhysicalLeftEar;

    [SerializeField] Transform AnimatedRightEar;
    [SerializeField] Rigidbody PhysicalRightEar;

    [Header("-Arms-")]
    [SerializeField] Transform AnimatedLeftUpperArm;
    [SerializeField] Rigidbody PhysicalLeftUpperArm;

    [SerializeField] Transform AnimatedLeftLowerArm;
    [SerializeField] Rigidbody PhysicalLeftLowerArm;

    [SerializeField] Transform AnimatedLeftHand;
    [SerializeField] Rigidbody PhysicalLeftHand;

    [SerializeField] Transform AnimatedRightUpperArm;
    [SerializeField] Rigidbody PhysicalRightUpperArm;

    [SerializeField] Transform AnimatedRightLowerArm;
    [SerializeField] Rigidbody PhysicalRightLowerArm;

    [SerializeField] Transform AnimatedRightHand;
    [SerializeField] Rigidbody PhysicalRightHand;

     [Header("-Tail-")]
    [SerializeField] Transform AnimatedTail1;
    [SerializeField] Rigidbody PhysicalTail1;

    [SerializeField] Transform AnimatedTail2;
    [SerializeField] Rigidbody PhysicalTail2;

    [SerializeField] Transform AnimatedTail3;
    [SerializeField] Rigidbody PhysicalTail3;

    [SerializeField] Transform AnimatedTail4;
    [SerializeField] Rigidbody PhysicalTail4;

    [SerializeField] Transform AnimatedTail5;
    [SerializeField] Rigidbody PhysicalTail5;

    [SerializeField] Transform AnimatedTail6;
    [SerializeField] Rigidbody PhysicalTail6;

    [SerializeField] Transform AnimatedTail7;
    [SerializeField] Rigidbody PhysicalTail7;

    [SerializeField] Transform AnimatedTail8;
    [SerializeField] Rigidbody PhysicalTail8;

    [SerializeField] Transform AnimatedTail9;
    [SerializeField] Rigidbody PhysicalTail9;

     [Header("-Legs-")]
    [SerializeField] Transform AnimatedLeftThigh;
    [SerializeField] Rigidbody PhysicalLeftThigh;

    [SerializeField] Transform AnimatedLeftUpperLeg;
    [SerializeField] Rigidbody PhysicalLeftUpperLeg;

    [SerializeField] Transform AnimatedLeftLowerLeg;
    [SerializeField] Rigidbody PhysicalLeftLowerLeg;

    [SerializeField] Transform AnimatedLeftFoot;
    [SerializeField] Rigidbody PhysicalLeftFoot;

    [SerializeField] Transform AnimatedRightThigh;
    [SerializeField] Rigidbody PhysicalRightThigh;

    [SerializeField] Transform AnimatedRightUpperLeg;
    [SerializeField] Rigidbody PhysicalRightUpperLeg;

    [SerializeField] Transform AnimatedRightLowerLeg;
    [SerializeField] Rigidbody PhysicalRightLowerLeg;

    [SerializeField] Transform AnimatedRightFoot;
    [SerializeField] Rigidbody PhysicalRightFoot;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
