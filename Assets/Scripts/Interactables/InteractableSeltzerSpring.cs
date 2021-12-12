using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableSeltzerSpring : Interactable
{
    // Drinking from pool

    public override void ChoiceWestInstantReaction()
    {
        base.ChoiceWestInstantReaction();
    }

    public override void ChoiceWestDelayedReaction()
    {
        base.ChoiceWestDelayedReaction();
        //heal player
    }

    // Filling up bottle

    public override void ChoiceSouthInstantReaction()
    {
        base.ChoiceSouthInstantReaction();
        //Inventory.instance.ChangeItemCount(1, -1); // remove empty bottle
    }

    public override void ChoiceSouthDelayedReaction()
    {
        base.ChoiceSouthDelayedReaction();
        Inventory.instance.ChangeItemCount(2, 1); // return selzter
    }

    // req checks

    public override bool ReqCheckWest()
    {
        return true; // should check HP
    }

    public override bool ReqCheckSouth()
    {
        if (Inventory.instance.items[1] > 0) return true;
        else return false;
    }
}
