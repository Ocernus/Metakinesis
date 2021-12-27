using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : Damageable
{
    public int maxHits;
    public GameObject particle;
    public Collider pairedCollider;
    public GameObject breakSound;

    private void Start()
    {
        if (pairedCollider) pairedCollider.enabled = false;
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        maxHits -= amount;
        if (particle) Instantiate(particle, transform.position, transform.rotation);
        if (breakSound) Instantiate(breakSound, transform.position, transform.rotation);
        if (maxHits <= 0)
        {
            if (pairedCollider) pairedCollider.enabled = true;
            Destroy(gameObject);
        }
    }
}
