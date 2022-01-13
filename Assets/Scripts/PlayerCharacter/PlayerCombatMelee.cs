using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCombatMelee : MonoBehaviour
{
    private bool onGuard;
    
    public void OnGuard(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            onGuard = true;
            
        }
        if (value.canceled)
        {
            onGuard = false;
        }
    }

    public void OnSlash(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (onGuard)
            {

            }
        }
        if (value.canceled)
        {
            
        }
    }
}
