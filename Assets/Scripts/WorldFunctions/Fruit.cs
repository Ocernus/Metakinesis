using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public Transform attackSetupPosition;
    Rigidbody rb;
    bool targetAttracted;
    public Transform stem;
    bool physicsLock;
    bool emberlingPresent;
    EmberlingBehavior targetEmberling;
    bool stayCheck;

    private void Start()
    {
        rb = GetComponentInChildren<Rigidbody>();
    }

    private void Update()
    {
        if (!physicsLock)
        {
            if (stem == null)
            {
                rb.useGravity = true;
                physicsLock = true;
            }
        }


        if (emberlingPresent)
        {
            if (!targetAttracted) AttractEmberling();             
        }
    }

    void AttractEmberling()
    {
        targetEmberling.GainInterestInHardFruit();
        targetEmberling.hardFruitSensed = true;
        targetEmberling.targetFruit = this;
        
        targetAttracted = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        EmberlingBehavior tempEmberling = other.GetComponent<EmberlingBehavior>();
        if (tempEmberling!=null)
        {
            emberlingPresent = true;
            targetEmberling = tempEmberling;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (!stayCheck)
        {
            EmberlingBehavior tempEmberling = other.GetComponent<EmberlingBehavior>();
            if (tempEmberling!=null)
            {
                emberlingPresent = true;
                targetEmberling = tempEmberling;
            }
            stayCheck = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        EmberlingBehavior tempEmberling = other.GetComponent<EmberlingBehavior>();
        if (tempEmberling!=null)
        {
            emberlingPresent = false;
            targetEmberling = null;
            targetAttracted = false;
        }
            
    }
}
