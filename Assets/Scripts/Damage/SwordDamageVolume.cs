using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDamageVolume : DamageVolume
{
    public PlayerMagic magic;

    public override void SpecialHitEffect()
    {
        base.SpecialHitEffect();
        magic.SolveHitReturns();
    }
}
