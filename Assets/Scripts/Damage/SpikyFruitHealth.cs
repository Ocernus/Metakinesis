using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikyFruitHealth : Damageable
{
    int toughness = 10;
    public Collider pairedCollider;

    private void Start()
    {
        
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        if (amount > toughness)
        {
            CrackDaCoconut();
        }
        else
        {
            Wobble();
        }
    }

    void CrackDaCoconut()
    {
        pairedCollider.transform.parent = null;
        pairedCollider.enabled = true;
        Destroy(gameObject);
    }

    void Wobble()
    {

    }
}
