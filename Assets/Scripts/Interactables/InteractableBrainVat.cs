using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBrainVat : Interactable
{
    // Give creepy totem

    public override void ChoiceWestInstantReaction()
    {
        base.ChoiceWestInstantReaction();
    }

    public override void ChoiceWestDelayedReaction()
    {
        base.ChoiceWestDelayedReaction();
        
    }

    // Buy seltzer

    public override void ChoiceSouthInstantReaction()
    {
        base.ChoiceSouthInstantReaction();
        Inventory.instance.ChangeItemCount(0, -10);
    }

    public override void ChoiceSouthDelayedReaction()
    {
        base.ChoiceSouthDelayedReaction();
        Inventory.instance.ChangeItemCount(3, 1);
    }

    // req checks

    public override bool ReqCheckWest()
    {
        return base.ReqCheckWest(); // check for creepy totem
    }

    public override bool ReqCheckSouth()
    {
        if (Inventory.instance.items[0] >= 10) return true;
        else return false;
    }
}
