using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableSwordSocket : Interactable
{
    public bool powered;
    public string poweredCommentText;
    public string poweredContextText;
    public string poweredWestText;
    public string poweredNorthText;
    public Transform dropPoint;

    private Emitter emitter;

    public override void Start()
    {
        base.Start();
        emitter = GetComponent<Emitter>();
    }

    public override void SendUIStrings()
    {
        base.SendUIStrings();
    }

    void SendPoweredUIStrings()
    {
        UIButtonManager.instance.RefreshNorthText(true, poweredNorthText);
        UIButtonManager.instance.RefreshWestText(true, poweredWestText);
    }

    public override void RefreshInteractability(bool possibility)
    {
        if (possibility)
        {            
            if (powered)
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
        if (powered)
        {
            print(poweredCommentText);
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
        base.ChoiceADelayedReaction();
        if (powered)
        {
            playerCharacter.GetComponent<SwordPlacement>().PickUp();
        }
        else
        {
            playerCharacter.GetComponent<SwordPlacement>().Drop(dropPoint);
        }
        powered = !powered;
        emitter.ToggleState();
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
