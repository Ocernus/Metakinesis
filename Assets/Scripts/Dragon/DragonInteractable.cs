using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonInteractable : Interactable
{
    public bool mounted;
    public string mountedCommentText;
    public string mountedContextText;
    public string mountedWestText;
    public string mountedSouthText;

    public Transform dismountPoint;
    public Transform mountPoint;
    public GameObject playerChar;

    public override void Start()
    {
        base.Start();
    }

    public override void SendUIStrings()
    {
        base.SendUIStrings();
    }

    void SendMountedUIStrings()
    {
        UIButtonManager.instance.RefreshSouthText(true, mountedSouthText);
        UIButtonManager.instance.RefreshWestText(true, mountedWestText);
    }

    public override void RefreshInteractability(bool possibility)
    {
        if (possibility)
        {
            if (mounted)
            {
                if (possibility) ActionButtonContextManager.instance.activeInteractable = this;
                else ActionButtonContextManager.instance.activeInteractable = null;
                SendMountedUIStrings();
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
        if (mounted)
        {
            print(mountedCommentText);
        }
        else
        {
            print(placeHolderComment);
        }
    }

    public override void ChoiceSouthInstantReaction()
    {
        base.ChoiceSouthInstantReaction();
        interactableEngaged = true;
        if (cam) cam.SetActive(true);
    }

    public override void ChoiceSouthDelayedReaction()
    {
        base.ChoiceWestDelayedReaction();
        

        if (mounted)
        {
            playerCharacter.transform.position = mountPoint.position;
            playerCharacter.transform.rotation = mountPoint.rotation;
            movement.ReturnPlayerControl();
            PlayerController.instance.EnableCharacterControl();
            playerChar.transform.parent = null;

            
            mounted = false;
        }
        else
        {
            playerCharacter.transform.position = mountPoint.position;
            playerCharacter.transform.rotation = mountPoint.rotation;
            movement.PausePlayerControl();
            PlayerController.instance.EnableFlightControls();
            playerChar.transform.parent = mountPoint.transform;
            mounted = true;
        }
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
