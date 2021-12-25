using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int index;
    // ? index 
    public int magicRechargeAmount;

    public GameObject soundObject;

    private void OnTriggerEnter(Collider other)
    {
        Inventory inventory = other.gameObject.GetComponentInChildren<Inventory>();
        if (inventory)
        {
            Inventory.instance.ChangeItemCount(index, 1);
            other.GetComponentInChildren<PlayerMagic>().SolveCollectionReturns(magicRechargeAmount);
            Instantiate(soundObject, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    public virtual void Collect()
    {

    }
}
