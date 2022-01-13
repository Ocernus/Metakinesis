using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCombatMelee : MonoBehaviour
{
    private bool onGuard;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnGuard(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            onGuard = true;
            //draw sword
            //hold shield
            //change movement style to slow
            TargetingManager.instance.LockOnToggle(true);
            
        }
        if (value.canceled)
        {
            onGuard = false;
            //change movement style to normal
            TargetingManager.instance.LockOnToggle(true);
        }
    }

    public void OnSlash(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            // do slash attack
            print("slash");
        }
        if (value.canceled)
        {
            
        }
    }

    public void OnStab(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            // do stab attack
            print("stab");
        }
        if (value.canceled)
        {

        }
    }

    public void OnBash(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            // do bash attack
            print("bash");
        }
        if (value.canceled)
        {

        }
    }
}
