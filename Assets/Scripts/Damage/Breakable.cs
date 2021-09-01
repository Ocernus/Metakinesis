using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : Damageable
{
    public int maxHits;
    public GameObject particle;
    public Collider pickupTrigger;
    public GameObject breakSound;

    private void Start()
    {
        pickupTrigger.enabled = false;
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        maxHits -= amount;
        Instantiate(particle, transform.position, transform.rotation);
        Instantiate(breakSound, transform.position, transform.rotation);
        if (maxHits <= 0)
        {
            pickupTrigger.enabled = true;
            Destroy(gameObject);
        }
    }
}
