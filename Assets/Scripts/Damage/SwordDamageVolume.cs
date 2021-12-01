using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDamageVolume : DamageVolume
{
    public PlayerMagic magic;
    public GameObject particles;

    public override void SpecialHitEffect()
    {
        base.SpecialHitEffect();
        Instantiate(particles, transform.position, transform.rotation);
        magic.SolveHitReturns();
    }
}
