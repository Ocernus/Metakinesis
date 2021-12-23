using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiMovement : MonoBehaviour
{
    bool present;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (present)
        {
            FollowTargetWitouthRotation(TaxiManager.instance.taxiHubs[0].transform, 10, 10);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Movement movement = other.GetComponent<Movement>();
        if (movement)
        {
            movement.parentingLock = true;
            other.transform.parent = transform;
            present = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Movement movement = other.GetComponent<Movement>();
        if (movement)
        {
            movement.parentingLock = false;
            other.transform.parent = null;
            present = false;
        }
    }

    void FollowTargetWitouthRotation(Transform target, float distanceToStop, float speed)
    {
        var direction = Vector3.zero;
        if (Vector3.Distance(transform.position, target.position) > distanceToStop)
        {
            direction = target.position - transform.position;
            rb.AddRelativeForce(direction.normalized * speed, ForceMode.Force);
        }
    }
}
