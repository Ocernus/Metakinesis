using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public int stepCount;

    public float walkSpeed;
    public float sprintSpeedMultiplier;
    private float performSprint;
    public float agentDistanceTolerance;

    public float runInputThreshold;
    public float lerpSpeed;

    public float jumpHeight;
    public float gravity;
    public float rotationSpeed;

    public bool rotationIsSet;

    public float movementMultiplier = 1;
    private float coyoteTime;
    public float coyoteTimeMax;
    private float landTime;
    public float landTimeMax;

    public AudioSource jumpSound;
    public GameObject stepSound;
    public AudioSource landSound;

    private bool controlledMovementAllowed;
    private bool shouldSnapRotation;

    private bool targetingRotationLock;

    private float inputX;
    private float inputY;
    private float inputMagnitude;
    private float currentSpeed;


    private Transform agentTarget;

    private Vector3 previousPosition;
    private Vector3 currentDirection;

    public Vector3 camForward;
    public Vector3 camRight;
    private Vector3 inputDirection;
    private Vector3 horizontalPush;

    private Vector3 vVel;
    public bool parentingLock;
    Vector3 moveVelocity;

    private CharacterController controller;
    private Camera cam;
    private Animator anim;
    private NavMeshAgent agent;
    private JumpCollider jumpCollider;
    private SwordAttack swordAttack;
    private PlayerMagic magic;

    int layerMask = 1 << 10;
    private GameObject hitObj;
    Vector3 newNormal;

    public enum States
    {
        onGround,
        inAir,

    }

    public States state;

    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        jumpCollider = GetComponentInChildren<JumpCollider>();
        swordAttack = GetComponent<SwordAttack>();
        magic = GetComponentInChildren<PlayerMagic>();

        controlledMovementAllowed = true;

        layerMask = ~layerMask;
    }    

    void Update()
    {
        

        currentDirection = controller.velocity;
        currentDirection.y = 0f;
        currentSpeed = currentDirection.magnitude / Time.deltaTime;

        camForward = cam.transform.forward;
        camRight = cam.transform.right;
        camForward.y = 0f;
        camRight.y = 0f;
        camForward.Normalize();
        camRight.Normalize();

        inputDirection = ((camForward * inputY) + (camRight * inputX)).normalized;
        inputMagnitude = Mathf.Max(Mathf.Abs(inputY), Mathf.Abs(inputX));

        if (inputMagnitude >= runInputThreshold) performSprint = 1;
        else performSprint = 0;

        float sprint = performSprint * sprintSpeedMultiplier;
        float speed = walkSpeed + (walkSpeed * sprint);

        //horizontalPush = Vector3.Lerp(currentDirection, inputDirection * speed * movementMultiplier, lerpSpeed); this was laggy when framerate dipped, felt like slipping on ice
        horizontalPush = inputDirection * speed * movementMultiplier;

        if (!parentingLock)
        {            
            vVel.y += gravity * Time.deltaTime;

            moveVelocity = vVel + horizontalPush;
            moveVelocity = AdjustVelocityToSlope(moveVelocity);
        }
        else
        {
            //vVel.y += gravity * Time.deltaTime + transform.parent.GetComponent<Rigidbody>().velocity.y;
            vVel.y += gravity * Time.deltaTime;
            moveVelocity = vVel + horizontalPush;
            moveVelocity = AdjustVelocityToSlope(moveVelocity);
        }
        

        //++
        if (controlledMovementAllowed) controller.Move((moveVelocity) * Time.deltaTime);
        else
        {
            //check for AI control here if needed later
            //might be able to use this functionality to orient player when landing
            transform.position = transform.parent.position;
            transform.rotation = transform.parent.rotation;
        }
        //++

        if (shouldSnapRotation)
        {
            if (AgentAtDestination() && !rotationIsSet) DoRotationSnap();
        }
        else RotateCharacter();

        anim.SetBool("Airborne", !jumpCollider.ready);
        anim.SetFloat("MoveVelocity", controller.velocity.magnitude);        
        anim.SetFloat("MoveX", Vector3.Dot(transform.right, inputDirection));
        anim.SetFloat("MoveZ", Vector3.Dot(transform.forward, inputDirection));

        switch (state)
        {
            case States.onGround:
                {
                    if (!controller.isGrounded)
                    {
                        coyoteTime += Time.deltaTime;
                        if (coyoteTime >= coyoteTimeMax)
                        {
                            state = States.inAir;
                            coyoteTime = 0;
                        }
                    }
                    else
                    {
                        coyoteTime = 0.0f;
                        if (vVel.y <0)
                        {
                            vVel.y = 0.0f;
                        }
                    }
                }
                break;
            case States.inAir:
                {
                    if (controller.isGrounded)
                    {
                        landTime += Time.deltaTime;
                        if (landTime >= landTimeMax)
                        {
                            landSound.Play();
                            state = States.onGround;
                            landTime = 0;
                        }                        
                    }
                    else
                    {
                        landTime = 0.0f;
                    }
                }
                break;
        }
    }

    Vector3 AdjustVelocityToSlope(Vector3 velocity)
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.2f, layerMask))
        {
            hitObj = hit.transform.gameObject;
            newNormal = hit.normal;
            var slopeRotation = Quaternion.FromToRotation(Vector3.up, newNormal);
            var adjustedVelocity = slopeRotation * velocity;
            if (adjustedVelocity.y < 0)
            {
                return adjustedVelocity;
            }
        }

        return velocity;
    }

    public void OnMoveX(InputAction.CallbackContext value)
    {
        inputX = value.ReadValue<float>();
    }

    public void OnMoveY(InputAction.CallbackContext value)
    {
        inputY = value.ReadValue<float>();
    }

    public void OnCharacterJump(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            Jump();
        }
    }

    public void OnSprint(InputAction.CallbackContext value)
    {
        /*
        if (value.started)
        {
            if (state == States.onGround)
            {
                performSprint = 1;
            }
            else performSprint = 0;
        }

        if (value.canceled)
        {
            performSprint = 0;
        }
        */
    }

    private void Jump()
    {
        if (jumpCollider.ready)
        {
            vVel.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);
            swordAttack.ExternalReset();
            jumpSound.Play();
        }
    }

    private void RotateCharacter()
    {
        if (targetingRotationLock)
        {
            var lookPos = TargetingManager.instance.activeTarget.transform.position - transform.position;
            lookPos.y = 0;
            var rot = Quaternion.LookRotation(lookPos);
            //transform.rotation = Quaternion.Slerp(transform.rotation, rot, Time.deltaTime * rotationSpeed);
            transform.rotation = rot;
            anim.SetFloat("MoveType", 1);
        }
        else
        {
            if (inputDirection != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(inputDirection);
            }
            anim.SetFloat("MoveType", 0);
        }        
    }
       

    public void LockRotation()
    {
        targetingRotationLock = true;
    }

    public void UnlockRotation()
    {
        targetingRotationLock = false;
    }

    private void DoRotationSnap()
    {
        transform.rotation = agentTarget.rotation;
        rotationIsSet = true;
    }

    public void PerformAgentMove(Transform target)
    {
        controlledMovementAllowed = false;
        shouldSnapRotation = true;
        controller.enabled = false;
        agent.enabled = true;
        agentTarget = target;
        agent.SetDestination(target.position);
    }

    public bool AgentAtDestination()
    {
        if (Vector3.Distance(agent.destination, transform.position) < agentDistanceTolerance) return true;
        else return false;
    }    

    public void PausePlayerControl()
    {
        transform.position = transform.parent.transform.position;
        transform.rotation = transform.parent.transform.rotation;
        controlledMovementAllowed = false;
        controller.enabled = false;
        //print("pause player controller called");
    }

    public void ReturnPlayerControl()
    {
        controlledMovementAllowed = true;
        shouldSnapRotation = false;
        controller.enabled = true;
        agent.enabled = false;
        rotationIsSet = false;
        //anim.SetTrigger();
    }

    public void Step()
    {
        stepCount += 1;
        magic.SolveStepCount(1);
        Instantiate(stepSound, transform.position, transform.rotation);
    }
}
