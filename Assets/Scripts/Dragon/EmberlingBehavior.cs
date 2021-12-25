using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmberlingBehavior : MonoBehaviour
{
    // This is the core behavior for the "Emberling" follower/pet.
    // Behaviors can be triggered from inside or outside this script.

    

    public enum Behaviors
    {
        idleHover
    }

    public static EmberlingBehavior instance;

    private void Awake()
    {
        instance = this;
    }

    public void TriggerBehavior()
    {

    }

    private void Update()
    {
        // check for fruit

    }
}
