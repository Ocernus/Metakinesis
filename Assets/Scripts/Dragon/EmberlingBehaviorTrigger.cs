using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmberlingBehaviorTrigger : MonoBehaviour
{
    EmberlingBehavior emberling;

    private void Start()
    {
        emberling = EmberlingBehavior.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        emberling.TriggerBehavior();
    }
}
