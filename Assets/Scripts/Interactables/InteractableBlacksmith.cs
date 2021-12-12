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

    public override void ChoiceWestInstantReaction()
    {
        
        Inventory.instance.ChangeItemCount(5, -swordCost);
    }

    public override void ChoiceWestDelayedReaction()
    {
        // give next tier of sword
        print("got next sword upgrade");
    }

    public override void ChoiceSouthInstantReaction()
    {
        Inventory.instance.ChangeItemCount(5, -armorCost);
    }

    public override void ChoiceSouthDelayedReaction()
    {
        
        health.IncreaseArmor();
        print("got next armor piece");
    }

    public override bool ReqCheckWest()
    {
        if (Inventory.instance.items[5] >= armorCost && health.armorCurrent < health.armorMax) return true;
        else return false;
    }

    public override bool ReqCheckSouth()
    {
        if (Inventory.instance.items[5] >= swordCost/* && sword not maxed out */) return true;
        else return false;
    }
}
