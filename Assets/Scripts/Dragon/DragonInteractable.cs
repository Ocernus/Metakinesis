using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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

    public GameObject dragonCam;
    public GameObject charCam;

    public string mountedContextTrigger;

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
                ActionButtonContextManager.instance.activeInteractable = this;
                SendMountedUIStrings();
            }
            else
            {
                
                ActionButtonContextManager.instance.activeInteractable = null;
                SendUIStrings();
                base.RefreshInteractability(possibility);
            }
        }
        else
        {
            ActionButtonContextManager.instance.activeInteractable = null;
            base.RefreshInteractability(possibility);
        }
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
        interactableEngaged = !interactableEngaged;
        
    }

    public override void ChoiceSouthDelayedReaction()
    {
        base.ChoiceSouthDelayedReaction();
        

        if (mounted)
        {
            Dismount();            
        }
        else
        {
            MountUp();            
        }
    }

    public void Dismount()
    {
        print("attempted dismount");
        playerChar.transform.parent = null;

        playerCharacter.transform.position = dismountPoint.position;
        playerCharacter.transform.rotation = dismountPoint.rotation;

        charCam.SetActive(true);
        dragonCam.SetActive(false);
        
        PlayerController.instance.EnableCharacterControl();
        movement.ReturnPlayerControl();

        mounted = false;
        RefreshInteractability(true);
    }

    public void MountUp()
    {
        playerChar.transform.parent = mountPoint.transform;

        /*
        playerCharacter.transform.position = mountPoint.position;
        playerCharacter.transform.rotation = mountPoint.rotation;
        */

        movement.PausePlayerControl();

        charCam.SetActive(false);
        dragonCam.SetActive(true);
        
        PlayerController.instance.EnableFlightControls();

        mounted = true;
        RefreshInteractability(true);
    }

    public override bool ReqCheckWest()
    {
        return true;
    }

    public override bool ReqCheckSouth()
    {
        return true;
    }

    public override void InteractionChooseSouth()
    {
        if (!mounted) base.InteractionChooseSouth();
        else
        {
            if (ReqCheckSouth())
            {
                StartCoroutine(InteractionTimer(choiceSouthTime)); //
                StartCoroutine(ChoiceSouthReactionTimer());
                anim.SetTrigger(mountedContextTrigger);
            }
        }
    }
}
