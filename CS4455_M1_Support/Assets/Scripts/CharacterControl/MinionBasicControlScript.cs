using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(Rigidbody), typeof(CapsuleCollider))]
[RequireComponent(typeof(CharacterInputController))]
public class MinionBasicControlScript : MonoBehaviour
{
    private Animator anim;	
    private Rigidbody rbody;
    private CharacterInputController cinput;
     
    public float forwardMaxSpeed = 1f;
    public float turnMaxSpeed = 1f;
      
    //Useful if you implement jump in the future...
    public float jumpableGroundNormalMaxAngle = 45f;
    public bool closeToJumpableGround;

    private int groundContactCount = 0;

    public bool IsGrounded
    {
        get
        {
            return groundContactCount > 0;
        }
    }


    void Awake()
    {

        anim = GetComponent<Animator>();

        if (anim == null)
            Debug.Log("Animator could not be found");

        rbody = GetComponent<Rigidbody>();

        if (rbody == null)
            Debug.Log("Rigid body could not be found");

        cinput = GetComponent<CharacterInputController>();

        if (cinput == null)
            Debug.Log("CharacterInputController could not be found");

    }


    // Use this for initialization
    void Start()
    {
        anim.applyRootMotion = false;
    }


    void Update()
    {

        float inputForward=0f;
        float inputTurn=0f;
      
        if (cinput.enabled)
        {
            inputForward = cinput.Forward;
            inputTurn = cinput.Turn;
        }

        //onCollisionXXX() doesn't always work for checking if the character is grounded from a playability perspective
        //Uneven terrain can cause the player to become technically airborne, but so close the player thinks they're touching ground.
        //Therefore, an additional raycast approach is used to check for close ground

        bool isGrounded = IsGrounded || CharacterCommon.CheckGroundNear(this.transform.position, jumpableGroundNormalMaxAngle, 0.85f, 0f, out closeToJumpableGround);


        //this.transform.Translate(Vector3.forward * cinput.Forward * Time.deltaTime * forwardMaxSpeed);
        //this.transform.Rotate(Vector3.up, cinput.Turn * Time.deltaTime * turnMaxSpeed);

        //It's supposed to be safe to not scale with Time.deltaTime (e.g. framerate correction) within FixedUpdate()
        //If you want to make that optimization, you can precompute your velocity-based translation using Time.fixedDeltaTime
        //We use rbody.MovePosition() as it's the most efficient and safest way to directly control position in Unity's Physics
        rbody.MovePosition(rbody.position +  this.transform.forward * inputForward * Time.deltaTime * forwardMaxSpeed);
        //Most characters use capsule colliders constrained to not rotate around X or Z axis
        //However, it's also good to freeze rotation around the Y axis too. This is because friction against walls/corners
        //can turn the character. This errant turn is disorienting to players. 
        //Luckily, we can break the frozen Y axis constraint with rbody.MoveRotation()
        //BTW, quaternions multiplied has the effect of adding the rotations together
        rbody.MoveRotation(rbody.rotation * Quaternion.AngleAxis(inputTurn * Time.deltaTime * turnMaxSpeed, Vector3.up));


        anim.SetFloat("velx", inputTurn); 
        anim.SetFloat("vely", inputForward);
        anim.SetBool("isFalling", !isGrounded);

    }


    //This is a physics callback
    void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.gameObject.tag == "ground")
        {
            ++groundContactCount;

            EventManager.TriggerEvent<MinionLandsEvent, Vector3, float>(collision.contacts[0].point, collision.impulse.magnitude);          
        }
						
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.gameObject.tag == "ground")
        {
            --groundContactCount;
        }
    }


}
