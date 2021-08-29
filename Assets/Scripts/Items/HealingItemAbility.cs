using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingItemAbility : ItemAbility
{
    PlayerHealth health;

    private void Start()
    {
        health = GetComponentInParent<PlayerHealth>();
    }

    public override bool CheckReq()
    {
        if (Inventory.instance.items[2] > 0) return true;
        else return false;
    }

    public override void PerformAbility()
    {
        base.PerformAbility();
        Inventory.instance.ChangeItemCount(2, -1);
        health.RestoreHitPoints();
    }

    public override void AbilityFailed()
    {
        base.AbilityFailed();
        print("no potions");
    }
}
