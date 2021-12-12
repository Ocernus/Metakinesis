using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonInteractable : Interactable
{
    
    public GameObject mountPoint;
    public GameObject playerChar;

    public override void Start()
    {
        base.Start();
    }

    public override void SendUIStrings()
    {
        base.SendUIStrings();
    }

    

    

    public override void ChoiceWestInstantReaction()
    {
        base.ChoiceWestInstantReaction();
    }

    public override void ChoiceWestDelayedReaction()
    {

        base.ChoiceWestDelayedReaction();
        print(placeHolderComment);
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
        playerCharacter.transform.position = transformTarget.position;
        playerCharacter.transform.rotation = transformTarget.rotation;
        movement.PausePlayerControl();
        PlayerController.instance.EnableFlightControls();
        playerChar.transform.parent = mountPoint.transform;
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
