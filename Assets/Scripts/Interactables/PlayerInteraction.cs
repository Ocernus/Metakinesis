using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    public Interactable activeInteractable;

    public void OnCharacterInteract(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (activeInteractable)
            {
                activeInteractable.InitiateInteraction();
            }

            else GetComponent<CharacterComments>().FreeComment();
        }
    }

    public void OnCharacterCancel(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (activeInteractable)
            {
                activeInteractable.InteractionCancel();
            }
        }
    }

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

    public void OnCharacterComment(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (activeInteractable)
            {
                activeInteractable.InteractionComment();
            }
        }
    }
}
