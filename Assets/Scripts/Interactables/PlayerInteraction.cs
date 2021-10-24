using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    public Interactable activeInteractable;
       

    public void OnCharacterChooseA(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (activeInteractable)
            {
                activeInteractable.InteractionChooseA();
            }
        }
    }

    public void OnCharacterChooseB(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (activeInteractable)
            {
                activeInteractable.InteractionChooseB();
            }
        }
    }
}
