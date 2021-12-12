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

    public override void ChoiceWestInstantReaction()
    {
        base.ChoiceWestInstantReaction();
    }

    public override void ChoiceWestDelayedReaction()
    {

        base.ChoiceWestDelayedReaction();
        if (bridge)
        {
            print(bridgeCommentText);
        }
        else
        {
            print(placeHolderComment);
        }
    }

    public override void ChoiceSouthInstantReaction()
    {
        base.ChoiceSouthInstantReaction();
    }

    public override void ChoiceSouthDelayedReaction()
    {
        base.ChoiceSouthDelayedReaction();
        if (bridge) ShipController.instance.ShiftToArchives();
        else ShipController.instance.ShiftToBridge();
        bridge = !bridge;

    }

    public override bool ReqCheckWest()
    {
        return true;
    }

    public override bool ReqCheckSouth()
    {
        return true;
    }
}
