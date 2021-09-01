using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int index;

    public GameObject soundObject;

    private void OnTriggerEnter(Collider other)
    {
        Inventory inventory = other.gameObject.GetComponentInChildren<Inventory>();
        if (inventory)
        {
            Inventory.instance.ChangeItemCount(index, 1);
            Instantiate(soundObject, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    public virtual void Collect()
    {

    }
}
