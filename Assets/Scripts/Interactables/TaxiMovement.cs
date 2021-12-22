using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiMovement : MonoBehaviour
{
    bool present;
    public Transform target;
    public float speed;
    private void Update()
    {
        if (present)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, TaxiManager.instance.taxiHubs[0].transform.position, step);
            //Vector3.MoveTowards(transform.position, TaxiManager.instance.taxiHubs[0].transform.position, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Movement movement = other.GetComponent<Movement>();
        if (movement)
        {
            movement.parentingLock = true;
            other.transform.parent = this.transform;
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
}
