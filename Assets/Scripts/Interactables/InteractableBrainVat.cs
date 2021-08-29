using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBrainVat : Interactable
{
    // Give creepy totem

    public override void ChoiceAInstantReaction()
    {
        base.ChoiceAInstantReaction();
    }

    public override void ChoiceADelayedReaction()
    {
        base.ChoiceADelayedReaction();
        
    }

    // Buy seltzer

    public override void ChoiceBInstantReaction()
    {
        base.ChoiceBInstantReaction();
        Inventory.instance.ChangeItemCount(0, -10);
    }

    public override void ChoiceBDelayedReaction()
    {
        base.ChoiceBDelayedReaction();
        Inventory.instance.ChangeItemCount(3, 1);
    }

    // req checks

    public override bool ReqCheckA()
    {
        return base.ReqCheckA(); // check for creepy totem
    }

    public override bool ReqCheckB()
    {
        if (Inventory.instance.items[0] >= 10) return true;
        else return false;
    }
}
