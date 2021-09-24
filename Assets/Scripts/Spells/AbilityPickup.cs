using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityPickup : MonoBehaviour
{
    public int index;

    public GameObject soundObject;

    private void OnTriggerEnter(Collider other)
    {
        SpellBook spellBook = other.gameObject.GetComponentInChildren<SpellBook>();
        if (spellBook)
        {
            spellBook.LearnSpell(index);
            Instantiate(soundObject, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    public virtual void Collect()
    {

    }
}
