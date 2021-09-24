using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellEnergyBall : Spell
{
    public GameObject projectile;
    public Transform launchPoint;

    public override void Use()
    {
        base.Use();
        Instantiate(projectile, launchPoint.position, launchPoint.rotation);
    }
}
