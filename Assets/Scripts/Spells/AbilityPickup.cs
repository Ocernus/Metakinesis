using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityPickup : MonoBehaviour
{
    public int index;

    public GameObject soundObject;

    private void OnTriggerEnter(Collider other)
    {
        Shoot shoot = other.gameObject.GetComponentInChildren<Shoot>();
        if (shoot)
        {
            shoot.Learn();
            Instantiate(soundObject, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    public virtual void Collect()
    {

    }
}
