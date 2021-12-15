using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string placeHolderComment;

    public string westText;
    public string southText;

    public string initialTrigger;
    public string commentTrigger;
    public string choiceWestTrigger;
    public string choiceSouthTrigger;
    public string exitTrigger;

    public float initialTime;
    public float commentTime;
    public float choiceWestTime;
    public float choiceSouthTime;
    public float exitTime;

    public GameObject cam;
    public GameObject agentTarget;
    public Transform transformTarget;

    protected bool interactableEngaged;
    bool timerRunning;
    bool volumeCheck;
    bool initiationCheck;
    bool exitCheck;
    bool controlMapLock;
    bool shouldReset;
    bool initTrigger;

    public bool lockInInteractable;

    protected GameObject playerCharacter;
    Animator anim;
    protected Movement movement;
       
    public virtual void Start()
    {
        playerCharacter = PlayerController.instance.gameObject;
        anim = playerCharacter.GetComponent<Animator>();
        movement = playerCharacter.GetComponent<Movement>();
    }

    private void Update()
    {
        if (volumeCheck)
        {
            if (FacingCheck()) RefreshInteractability(true);
            else RefreshInteractability(false);
        }
        
        if (lockInInteractable)
        {
            if (interactableEngaged)
            {
                if (!initiationCheck) //Put anything here that you want to happen 
                {
                    StartCoroutine(InteractionTimer(initialTime));

                    /*
                    if (cam) cam.SetActive(true);
                    else print("no cam");
                    */


                    if (agentTarget)
                    {
                        movement.PerformAgentMove(agentTarget.transform);
                        if (movement.rotationIsSet)
                        {
                            initiationCheck = true;
                            anim.SetTrigger(initialTrigger);
                        }
                    }
                    else initiationCheck = true;
                    
                }

                if (exitCheck && !timerRunning)
                {
                    exitCheck = false;
                    interactableEngaged = false;
                    shouldReset = true;
                    //PlayerController.instance.EnableCharacterControl();
                    //PlayerController.instance.gameObject.GetComponent<Movement>().ReturnPlayerControl();
                }

                if (!exitCheck && !timerRunning)
                {
                    SendUIStrings();
                    RefreshInteractability(true);
                    if (!controlMapLock)
                    {
                        controlMapLock = true;
                        //PlayerController.instance.EnableInteractableControl(); // This needs to change to an interactable specific control scheme, like LADDER, DOOR, CHEST, PUZZLE, NPC
                        //PlayerController.instance.EnableFlightControls();
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
                    print("interactable should reset");
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
        /*
        
        */
    }

    public virtual void ChoiceWestInstantReaction()
    {
        //print("placeholder instant reaction A"); //PFI
    }

    public virtual void ChoiceWestDelayedReaction()
    {
        //print("placeholder delayed reaction A"); //PFI and possible inventory change
    }

    public virtual void ChoiceSouthInstantReaction()
    {
        //print("placeholder instant reaction B"); //PFI
    }

    public virtual void ChoiceSouthDelayedReaction()
    {
        //print("placeholder delayed reaction B"); //PFI and possible inventory change
    }   

    public void InteractionChooseWest()
    {
        if (ReqCheckWest())
        {
            StartCoroutine(InteractionTimer(choiceWestTime)); //
            StartCoroutine(ChoiceWestReactionTimer());
            anim.SetTrigger(choiceWestTrigger);
        }        
    }

    public void InteractionChooseSouth()
    {
        if (ReqCheckSouth())
        {
            StartCoroutine(InteractionTimer(choiceSouthTime)); //
            StartCoroutine(ChoiceSouthReactionTimer());
            anim.SetTrigger(choiceSouthTrigger);
        }       
    }

    public virtual bool ReqCheckWest()
    {
        return false;
    }

    public virtual bool ReqCheckSouth()
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

    IEnumerator ChoiceWestReactionTimer()
    {
        ChoiceWestInstantReaction();
        yield return new WaitForSeconds(choiceWestTime);
        ChoiceWestDelayedReaction();
    }

    IEnumerator ChoiceSouthReactionTimer()
    {
        ChoiceSouthInstantReaction();
        yield return new WaitForSeconds(choiceSouthTime);
        ChoiceSouthDelayedReaction();
    }

    //

    public virtual void SendUIStrings()
    {
        UIButtonManager.instance.RefreshSouthText(true, southText);
        UIButtonManager.instance.RefreshWestText(true, westText);
    }

    public virtual void RefreshInteractability(bool possibility)
    {
        UIButtonManager.instance.RefreshSouthText(possibility, southText);
        UIButtonManager.instance.RefreshWestText(possibility, westText);
        
        if (possibility) playerCharacter.GetComponent<PlayerInteraction>().activeInteractable = this;
        else playerCharacter.GetComponent<PlayerInteraction>().activeInteractable = null; // This could get a little screwy if interactables are too close or overlapping
        
        if (possibility) ActionButtonContextManager.instance.activeInteractable = this;
        else ActionButtonContextManager.instance.activeInteractable = null;
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
