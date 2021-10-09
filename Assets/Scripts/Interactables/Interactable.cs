using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string placeHolderComment;

    public string initialContextText;
    public string southText;
    public string eastText;
    public string westText;
    public string northText;

    public string initialTrigger;
    public string commentTrigger;
    public string choiceATrigger;
    public string choiceBTrigger;
    public string exitTrigger;

    public float initialTime;
    public float commentTime;
    public float choiceATime;
    public float choiceBTime;
    public float exitTime;

    public GameObject cam;
    public GameObject agentTarget;

    bool interactableEngaged;
    bool timerRunning;
    bool volumeCheck;
    bool initiationCheck;
    bool exitCheck;
    bool controlMapLock;
    bool shouldReset;
    bool initTrigger;

    protected GameObject playerCharacter;
    Animator anim;
    Movement movement;
       
    public virtual void Start()
    {
        playerCharacter = PlayerController.instance.gameObject;
        anim = playerCharacter.GetComponent<Animator>();
        movement = playerCharacter.GetComponent<Movement>();
    }

    private void Update()
    {
        if (interactableEngaged)
        {
            if (!initiationCheck) 
            {
                StartCoroutine(InteractionTimer(initialTime));

                if (cam) cam.SetActive(true);
                else print("no cam");
                if (agentTarget) movement.PerformAgentMove(agentTarget.transform);
                else print("no agent target");
                if (movement.rotationIsSet)
                {
                    initiationCheck = true;
                    anim.SetTrigger(initialTrigger);
                }
            }

            if (exitCheck && !timerRunning)
            {
                exitCheck = false;
                interactableEngaged = false;
                shouldReset = true;
                PlayerController.instance.EnableCharacterControl();
                PlayerController.instance.gameObject.GetComponent<Movement>().ReturnPlayerControl();
            }

            if (!exitCheck && !timerRunning)
            {
                SendUIStrings();
                if (!controlMapLock)
                {
                    controlMapLock = true;
                    PlayerController.instance.EnableInteractableControl(); // This needs to change to an interactable specific control scheme, like LADDER, DOOR, CHEST, PUZZLE, NPC
                }                
            }
            else
            {
                UIButtonManager.instance.HideAllButtonTexts();
            }
        }
        else
        {
            if (shouldReset)
            {
                shouldReset = false;
                controlMapLock = false;
                initiationCheck = false;
                UIButtonManager.instance.ResetAllButtonTexts();
            }

            if (volumeCheck)
            {
                if (FacingCheck()) RefreshInteractability(true);
                else RefreshInteractability(false);
            }            
        }
    }

    public virtual void ChoiceAInstantReaction()
    {
        //print("placeholder instant reaction A"); //PFI
    }

    public virtual void ChoiceADelayedReaction()
    {
        //print("placeholder delayed reaction A"); //PFI and possible inventory change
    }

    public virtual void ChoiceBInstantReaction()
    {
        //print("placeholder instant reaction B"); //PFI
    }

    public virtual void ChoiceBDelayedReaction()
    {
        //print("placeholder delayed reaction B"); //PFI and possible inventory change
    }

    // INITIATING INTERACTABLE ENGAGEMENT

    public void InitiateInteraction()
    {        
        interactableEngaged = true;
        
    }

    //  ENGAGED IN INTERACTABLE
    
    public virtual void InteractionComment()
    {
        StartCoroutine(InteractionTimer(commentTime)); //
        
        print(placeHolderComment);
    }

    public void InteractionChooseA()
    {
        if (ReqCheckA())
        {
            StartCoroutine(InteractionTimer(choiceATime)); //
            StartCoroutine(ChoiceAReactionTimer());
            anim.SetTrigger(choiceATrigger);
        }        
    }

    public void InteractionChooseB()
    {
        if (ReqCheckB())
        {
            StartCoroutine(InteractionTimer(choiceBTime)); //
            StartCoroutine(ChoiceBReactionTimer());
            anim.SetTrigger(choiceBTrigger);
        }       
    }

    public void InteractionCancel()
    {
        StartCoroutine(InteractionTimer(exitTime)); //
        anim.SetTrigger(exitTrigger);
        exitCheck = true;
        if (cam) cam.SetActive(false);
        else print("no cam");
    }

    public virtual bool ReqCheckA()
    {
        return false;
    }

    public virtual bool ReqCheckB()
    {
        return false;
    }

    // TIMERS

    protected IEnumerator InteractionTimer(float time)
    {        
        timerRunning = true;
        yield return new WaitForSeconds(time);
        timerRunning = false;
    }

    IEnumerator ChoiceAReactionTimer()
    {
        ChoiceAInstantReaction();
        yield return new WaitForSeconds(choiceATime);
        ChoiceADelayedReaction();
    }

    IEnumerator ChoiceBReactionTimer()
    {
        ChoiceBInstantReaction();
        yield return new WaitForSeconds(choiceBTime);
        ChoiceBDelayedReaction();
    }

    //

    public virtual void SendUIStrings()
    {
        UIButtonManager.instance.RefreshEastText(true, eastText);
        UIButtonManager.instance.RefreshSouthText(true, southText);
        UIButtonManager.instance.RefreshNorthText(true, northText);
        UIButtonManager.instance.RefreshWestText(true, westText);
    }

    void RefreshInteractability(bool possibility)
    {
        UIButtonManager.instance.RefreshNorthText(possibility, initialContextText);
        if (possibility) playerCharacter.GetComponent<PlayerInteraction>().activeInteractable = this;
        else playerCharacter.GetComponent<PlayerInteraction>().activeInteractable = null; // This could get a little screwy if interactables are too close or overlapping
    }

    bool FacingCheck()
    {
        float dir = Vector3.Dot((transform.position - playerCharacter.transform.position).normalized, playerCharacter.transform.forward);
        return (dir > 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerCharacter) volumeCheck = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == playerCharacter) volumeCheck = false;
        RefreshInteractability(false);
    }
}
