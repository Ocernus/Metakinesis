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
    public float fallenFruitLingerTime;

    public Fruit targetFruit;
    Vector3 destination;
    float moveDistance;
    float dashDistance;
    bool timerRunning;

    // -- //

    public int focusLimit;
    public int usedFocus;
    public int hardFruitFocus;
    public int charFocus;
    public int skyWormFocus;

    public bool hardFruitSensed;

    // -- //


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


    

    private void Update() // mostly a behavior web/state machine, can jump around between states
    {
        if (behaviorEnabled)
        {
            switch (behavior)
            {
                case Behaviors.idleHover:
                    {
                        InterestCheck();

                    }
                    break;

                    // Fruit behaviors start //

                case Behaviors.movingToFruitSetupPoint: 
                    {
                        moveDistance = Vector3.Distance(transform.position, destination);

                        stem = targetFruit.stem;
                        SetDestination(targetFruit.attackSetupPosition.position);

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
                            behavior = Behaviors.attackStem; 
                        }

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
                            
                        }
                        else
                        {
                            rb.velocity = Vector3.zero;
                            transform.LookAt(targetFruit.transform.position);
                            if (!timerRunning) StartCoroutine(WaitTimer(fallenFruitLingerTime));

                        }


                    }
                    break;

                    // Fruit behaviors end //

                case Behaviors.followPlayer:
                    {

                    }
                    break;
                case Behaviors.idlePerch:
                    {

                    }
                    break;
                
            }
        }
    }

    

    public void InterestCheck() //switches behaviors based on interest levels and focus levels
    {
        if (hardFruitFocus > 0)
        {
            if (hardFruitSensed)
            {
                behavior = Behaviors.movingToFruitSetupPoint;
            }
        }
    }

    

    public void GainInterestInHardFruit()
    {
        if (hardFruitFocus < 1)
        {
            hardFruitFocus += 1;
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

    public IEnumerator WaitTimer(float t)
    {
        timerRunning = true;
        yield return new WaitForSeconds(t);
        timerRunning = false;
    }
}
