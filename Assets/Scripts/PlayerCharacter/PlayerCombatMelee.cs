using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCombatMelee : MonoBehaviour
{
    private bool onGuard;

    public enum OnGuardOptions
    {

    }

    public OnGuardOptions option;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (onGuard)
        {

        }
    }

    public void OnGuard(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            onGuard = true;
            // if targetables are around, lock on to nearest, else lock camera forward)
            // raise shield
        }
        if (value.canceled)
        {
            onGuard = false;
            // reset camera
            // lower shield
        }
    }
}
