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
        //print("mounted ui strings sent");
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
            else
            {
                ActionButtonContextManager.instance.activeInteractable = null;
                SendUIStrings();
                base.RefreshInteractability(possibility);
            }
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
        SendMountedUIStrings();
    }

    /*
    public void Dismount(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            print("attempted dismount");
            charCam.SetActive(true);
            dragonCam.SetActive(false);
            playerChar.transform.parent = null;
            playerCharacter.transform.position = dismountPoint.position;
            playerCharacter.transform.rotation = dismountPoint.rotation;
            PlayerController.instance.EnableCharacterControl();
            movement.ReturnPlayerControl();
            mounted = false;
        }
        
    }
    */

    public void MountUp()
    {
        print("mount up");
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
        SendMountedUIStrings();
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
