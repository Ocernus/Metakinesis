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
        charCam.SetActive(true);
        dragonCam.SetActive(false);
        playerChar.transform.parent = null;
        playerCharacter.transform.position = dismountPoint.position;
        playerCharacter.transform.rotation = dismountPoint.rotation;
        PlayerController.instance.EnableCharacterControl();
        movement.ReturnPlayerControl();
        mounted = false;
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
        charCam.SetActive(false);
        dragonCam.SetActive(true);
        movement.PausePlayerControl();
        playerCharacter.transform.position = mountPoint.position;
        playerCharacter.transform.rotation = mountPoint.rotation;
        PlayerController.instance.EnableFlightControls();
        playerChar.transform.parent = mountPoint.transform;
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
