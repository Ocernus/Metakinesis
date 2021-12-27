using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public Transform attackSetupPosition;
    Rigidbody rb;
    bool targetAttracted;
    public Transform stem;
    bool updateLock;

    private void Start()
    {
        rb = GetComponentInChildren<Rigidbody>();
    }

    private void Update()
    {
        if (!updateLock)
        {
            if (stem == null)
            {
                rb.useGravity = true;
                updateLock = true;
            }
        }    
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (!targetAttracted)
        {
            EmberlingBehavior emberling = other.GetComponent<EmberlingBehavior>();
            if (emberling)
            {
                emberling.targetFruit = this;
                emberling.stem = stem;
                emberling.SetDestination(attackSetupPosition.position);
                emberling.TriggerBehavior(EmberlingBehavior.Behaviors.movingToFruitSetupPoint);
                targetAttracted = true;
            }
        }        
    }

    private void OnTriggerExit(Collider other)
    {
        targetAttracted = false;
    }

    private void Fall()
    {

    }
}
