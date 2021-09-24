using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBlacksmith : Interactable
{
    public int armorCost;
    public int swordCost;

    PlayerHealth health;

    public override void Start()
    {
        base.Start();
        health = playerCharacter.GetComponent<PlayerHealth>();
    }

    public override void ChoiceAInstantReaction()
    {
        Inventory.instance.ChangeItemCount(5, -armorCost);
    }

    public override void ChoiceADelayedReaction()
    {
        health.IncreaseArmor();
        print("got next armor piece");
    }

    public override void ChoiceBInstantReaction()
    {
        Inventory.instance.ChangeItemCount(5, -swordCost);
    }

    public override void ChoiceBDelayedReaction()
    {
        // give next tier of sword
        print("got next sword upgrade");
    }

    public override bool ReqCheckA()
    {
        if (Inventory.instance.items[5] >= armorCost && health.armorCurrent < health.armorMax) return true;
        else return false;
    }

    public override bool ReqCheckB()
    {
        if (Inventory.instance.items[5] >= swordCost/* && sword not maxed out */) return true;
        else return false;
    }
}
