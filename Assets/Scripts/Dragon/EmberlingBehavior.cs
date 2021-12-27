using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmberlingBehavior : MonoBehaviour
{
    // This is the core behavior for the "Emberling" follower/pet.
    // Behaviors can be triggered from inside or outside this script.

    public bool behaviorEnabled;
    bool detectingFruit;
    public Transform stem;

    public float moveSpeed;
    public float dashSpeed;
    public float moveDistanceTolerance;
    public float dashDistanceTolerance;

    public Fruit targetFruit;
    Vector3 destination;
    float moveDistance;
    float dashDistance;


    public enum Behaviors
    {
        idleHover,
        attackStem,
        followPlayer,
        idlePerch,
        movingToFruitSetupPoint
    }

    public Behaviors behavior;

    Rigidbody rb;

    public static EmberlingBehavior instance;

    private void Awake()
    {
        instance = this;
    }

    //**

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        TriggerBehavior(Behaviors.idleHover);
    }

    //**
        

    private void Update()
    {
        if (behaviorEnabled)
        {
            switch (behavior)
            {
                case Behaviors.idleHover:
                    {

                    }
                    break;
                case Behaviors.attackStem:
                    {
                        if (stem)
                        {
                            dashDistance = Vector3.Distance(transform.position, stem.transform.position);
                            if (dashDistance > dashDistanceTolerance)
                            {
                                //pre-emptive chirp
                                transform.LookAt(stem);
                                rb.AddForce(transform.forward * dashSpeed);
                            }
                            else
                            {
                                rb.velocity = Vector3.zero;
                                transform.LookAt(targetFruit.transform.position);
                                //behavior = Behaviors.attackStem; // should be context sensitive
                            }
                        }
                        else
                        {
                            rb.velocity = Vector3.zero;
                            transform.LookAt(targetFruit.transform.position);
                            //behavior = Behaviors.attackStem; // should be context sensitive
                        }


                    }
                    break;
                case Behaviors.followPlayer:
                    {

                    }
                    break;
                case Behaviors.idlePerch:
                    {

                    }
                    break;
                case Behaviors.movingToFruitSetupPoint: // should be context sensitive
                    {
                        moveDistance = Vector3.Distance(transform.position, destination);
                        if (moveDistance > moveDistanceTolerance)
                        {
                            // smell fruit chirp
                            transform.LookAt(destination);
                            // sighted chirp
                            rb.AddForce(transform.forward * moveSpeed);
                        }
                        else
                        {
                            rb.velocity = Vector3.zero;
                            transform.LookAt(stem.position);
                            behavior = Behaviors.attackStem; // should be context sensitive
                        }
                        
                    }
                    break;
            }
        }      
    }

    public void TriggerBehaviorWithFollowUp(Behaviors a, Behaviors b)
    {

    }

    public void TriggerBehavior(Behaviors index)
    {
        behavior = index;
    }

    public void EnableBehavior(bool toggle)
    {
        behaviorEnabled = toggle;
    }

    public void SetDestination(Vector3 position)
    {
        destination = position;
    }
}
