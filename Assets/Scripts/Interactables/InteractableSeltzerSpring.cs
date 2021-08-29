using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableSeltzerSpring : Interactable
{
    // Drinking from pool

    public override void ChoiceAInstantReaction()
    {
        base.ChoiceAInstantReaction();
    }

    public override void ChoiceADelayedReaction()
    {
        base.ChoiceADelayedReaction();
        //heal player
    }

    // Filling up bottle

    public override void ChoiceBInstantReaction()
    {
        base.ChoiceBInstantReaction();
        //Inventory.instance.ChangeItemCount(1, -1); // remove empty bottle
    }

    public override void ChoiceBDelayedReaction()
    {
        base.ChoiceBDelayedReaction();
        Inventory.instance.ChangeItemCount(2, 1); // return selzter
    }

    // req checks

    public override bool ReqCheckA()
    {
        return true; // should check HP
    }

    public override bool ReqCheckB()
    {
        if (Inventory.instance.items[1] > 0) return true;
        else return false;
    }
}
