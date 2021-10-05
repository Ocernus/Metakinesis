using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenerSpecialBehavior : MonoBehaviour
{
    private Movement movement;


    void Start()
    {
        movement = GetComponentInParent<Movement>();
    }

    void Update()
    {
        if (movement.camForward != Vector3.zero) transform.forward = movement.camForward;
    }
}
