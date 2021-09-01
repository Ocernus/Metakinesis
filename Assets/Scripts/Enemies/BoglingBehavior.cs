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

    public AudioSource ambushSound;
    public GameObject flailSound; //using looping audio source
    public AudioSource retreatSound;

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
                    if (!flailSound.activeInHierarchy) flailSound.SetActive(true);
                }
                else
                {
                    agent.SetDestination(transform.position);
                    animator.SetTrigger("Hide");
                    //flailSound.GetComponent<AudioSource>().Stop();
                    flailSound.SetActive(false);
                    retreatSound.Play();
                    Invoke("Reset", resetTime);
                    inPursuit = false;
                }
            }
        }
        else
        {
            agent.SetDestination(transform.position);
            if (flailSound.activeInHierarchy) flailSound.SetActive(false);
        }
    }

    public void TriggerAmbush()
    {
        if (ready)
        {
            animator.SetTrigger("Ambush");
            ambushSound.Play();
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
