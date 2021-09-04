using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTargetHealth : Damageable
{
    public GameObject damageSound;

    public override void TakeDamage(int amount)
    {
        Instantiate(damageSound, transform.position, transform.rotation);
    }
}
