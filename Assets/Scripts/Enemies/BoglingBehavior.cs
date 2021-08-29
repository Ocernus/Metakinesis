using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BoglingBehavior : MonoBehaviour
{
    public float ambushTime;
    public float resetTime;
    public float pursuitRange;
    public float attackRange;

    Animator animator;
    PlayerController player;
    NavMeshAgent agent;

    bool ready;
    float distance;
    bool inPursuit;
    bool stunned;
    Vector3 originalPosition;
    Quaternion originalRotation;

    private void Start()
    {
        animator = GetComponent<Animator>();
        player = PlayerController.instance;
        agent = GetComponent<NavMeshAgent>();
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        ready = true;
    }

    private void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);
        if (!stunned)
        {
            if (inPursuit)
            {
                if (distance < attackRange)
                {
                    agent.SetDestination(transform.position);
                }
                else if (distance < pursuitRange)
                {
                    agent.SetDestination(player.transform.position);
                }
                else
                {
                    agent.SetDestination(transform.position);
                    animator.SetTrigger("Hide");
                    Invoke("Reset", resetTime);
                    inPursuit = false;
                }
            }
        }
        else agent.SetDestination(transform.position);
    }

    public void TriggerAmbush()
    {
        if (ready)
        {
            animator.SetTrigger("Ambush");
            Invoke("Pursuit", ambushTime);
            ready = false;
        }        
    }

    void Pursuit()
    {
        inPursuit = true;
    }

    public void HaltAllAction()
    {
        inPursuit = false;
        agent.SetDestination(transform.position);
    }

    private void Reset()
    {
        transform.position = originalPosition;
        transform.rotation = originalRotation;
        ready = true;
    }

    public void Flinch(bool a)
    {
        stunned = a;
    }
}
