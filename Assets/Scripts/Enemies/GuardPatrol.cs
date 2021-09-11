using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardPatrol : MonoBehaviour
{
    public float waitTimeMax;
    private float waitTimeCurrent;
    public Transform[] patrolPoints;
    private int patrolPointIndex;
    private bool destinationSet;
    private NavMeshAgent agent;
    private float distance;

    private enum States
    {
        patrolling,
        waiting,
        aprehending
    }

    private States state;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        switch (state)
        {
            case States.patrolling:
                {
                    distance = Vector3.Distance(transform.position, patrolPoints[patrolPointIndex].position);
                    if (distance < 0.1f) ChangeToWaiting();
                    else if (!destinationSet) SetPatrolPoint();
                }
                break;
            case States.waiting:
                {
                    if (waitTimeCurrent < waitTimeMax) waitTimeCurrent += Time.deltaTime;
                    else ChangeToPatrolling();
                }
                break;
            case States.aprehending:
                {

                }
                break;
        }
    }

    void SetPatrolPoint()
    {
        agent.SetDestination(patrolPoints[patrolPointIndex].position);
        destinationSet = true;
    }

    void ChangeToWaiting()
    {
        transform.position = patrolPoints[patrolPointIndex].position;
        state = States.waiting;
        destinationSet = false;
    }

    void ChangeToPatrolling()
    {        
        if (patrolPointIndex >= patrolPoints.Length - 1) patrolPointIndex = 0;
        else patrolPointIndex += 1;
        state = States.patrolling;
        waitTimeCurrent = 0;
    }
}
