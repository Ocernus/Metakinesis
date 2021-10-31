using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableSootRoomShipControls : Interactable
{
    public bool bridge;
    public string bridgeCommentText;
    public string bridgeContextText;
    public string bridgeWestText;
    public string bridgeNorthText;

    public override void SendUIStrings()
    {
        base.SendUIStrings();
    }

    void SendPoweredUIStrings()
    {
        UIButtonManager.instance.RefreshNorthText(true, bridgeNorthText);
        UIButtonManager.instance.RefreshWestText(true, bridgeWestText);
    }

    public override void RefreshInteractability(bool possibility)
    {
        if (possibility)
        {
            if (bridge)
            {
                if (possibility) ActionButtonContextManager.instance.activeInteractable = this;
                else ActionButtonContextManager.instance.activeInteractable = null;
                SendPoweredUIStrings();
            }
            else base.RefreshInteractability(possibility);
        }
        else base.RefreshInteractability(possibility);
    }

    public override void ChoiceAInstantReaction()
    {
        base.ChoiceAInstantReaction();
    }

    public override void ChoiceADelayedReaction()
    {

        base.ChoiceADelayedReaction();
        if (bridge)
        {
            print(bridgeCommentText);
        }
        else
        {
            print(placeHolderComment);
        }
    }

    public override void ChoiceBInstantReaction()
    {
        base.ChoiceBInstantReaction();
    }

    public override void ChoiceBDelayedReaction()
    {
        base.ChoiceBDelayedReaction();
        if (bridge) ShipController.instance.ShiftToArchives();
        else ShipController.instance.ShiftToBridge();
        bridge = !bridge;

    }

    public override bool ReqCheckA()
    {
        return true;
    }

    public override bool ReqCheckB()
    {
        return true;
    }
}
