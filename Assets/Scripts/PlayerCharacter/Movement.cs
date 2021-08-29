using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public float speed;
    public float agentDistanceTolerance;

    public float jumpHeight;
    public float gravity;

    public bool grounded;

    public float rotationSpeed;

    public bool rotationIsSet;

    public float movementMultiplier = 1;
    

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

    private Vector2 rawInputMovement;
    private Vector3 camForward;
    private Vector3 camRight;
    private Vector3 hDir;
    private Vector3 hVel;

    private Vector3 vVel;

    private CharacterController controller;
    private Camera cam;
    private Animator anim;
    private NavMeshAgent agent;
    private JumpCollider jumpCollider;
    private SwordAttack swordAttack;

    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        jumpCollider = GetComponentInChildren<JumpCollider>();
        swordAttack = GetComponent<SwordAttack>();

        controlledMovementAllowed = true;
    }

    public void OnCharacterMovement(InputAction.CallbackContext value)
    {
        rawInputMovement = value.ReadValue<Vector2>();
    }

    public void OnCharacterJump(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            Jump();
        }
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

        hDir = ((camForward * rawInputMovement.y) + (camRight * rawInputMovement.x)).normalized;
        hVel = hDir * speed * movementMultiplier;

        grounded = controller.isGrounded;
        if (grounded && vVel.y < 0)
        {
            vVel.y = 0f;

        }
        vVel.y += gravity * Time.deltaTime;

        if (controlledMovementAllowed) controller.Move((hVel + vVel) * Time.deltaTime);

        if (shouldSnapRotation)
        {
            if (AgentAtDestination() && !rotationIsSet) DoRotationSnap();
        }
        else RotateCharacter();

        anim.SetBool("Airborne", !jumpCollider.ready);
        anim.SetFloat("MoveVelocity", currentSpeed / speed);        
        anim.SetFloat("MoveX", Vector3.Dot(transform.right, hDir));
        anim.SetFloat("MoveZ", Vector3.Dot(transform.forward, hDir));
    }

    private void Jump()
    {
        if (jumpCollider.ready)
        {
            vVel.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);
            swordAttack.ExternalReset();
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
            if (currentDirection != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(currentDirection);
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

    public void ReturnPlayerControl()
    {
        controlledMovementAllowed = true;
        shouldSnapRotation = false;
        controller.enabled = true;
        agent.enabled = false;
        rotationIsSet = false;
    }


}
