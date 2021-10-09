using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableSwordSocket : Interactable
{
    public bool powered;
    public string poweredCommentText;
    public string poweredContextText;
    public string poweredSouthText;
    public string poweredEastText;
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
        if (!powered) base.SendUIStrings();
        else SendPoweredUIStrings();
    }

    void SendPoweredUIStrings()
    {
        UIButtonManager.instance.RefreshEastText(true, poweredEastText);
        UIButtonManager.instance.RefreshSouthText(true, poweredSouthText);
        UIButtonManager.instance.RefreshNorthText(true, poweredNorthText);
        UIButtonManager.instance.RefreshWestText(true, poweredWestText);
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
            playerCharacter.GetComponent<SwordPlacement>().PickUp();
        }
        else
        {
            playerCharacter.GetComponent<SwordPlacement>().Drop(dropPoint);
        }
        powered = !powered;
        emitter.ToggleState();
        
    }

    public override void ChoiceBInstantReaction()
    {
        base.ChoiceBInstantReaction();
    }

    public override void ChoiceBDelayedReaction()
    {
        base.ChoiceBDelayedReaction();
    }

    public override bool ReqCheckA()
    {
        return true;
    }

    public override bool ReqCheckB()
    {
        return true;
    }

    public override void InteractionComment()
    {
        if (!powered) base.InteractionComment();
        else
        {
            StartCoroutine(InteractionTimer(commentTime)); //

            print(poweredCommentText);
        }
    }
}
