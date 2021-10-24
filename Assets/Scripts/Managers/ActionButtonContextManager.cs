using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionButtonContextManager : MonoBehaviour
{

    public SwordAttack swordAttack;
    public Interactable activeInteractable;

    public static ActionButtonContextManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void OnNorthAction(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (activeInteractable)
            {
                activeInteractable.InteractionChooseA();
            }
            else
            {
                print("ha ha ha");
            }
        }        
    }

    public void OnWestAction(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (activeInteractable)
            {
                activeInteractable.InteractionChooseB();
            }
            else
            {
                if (Inventory.instance.swordEquipped) swordAttack.Attack();
                else
                {
                    print("<<<<<");
                }
            }
        }        
    }
}
