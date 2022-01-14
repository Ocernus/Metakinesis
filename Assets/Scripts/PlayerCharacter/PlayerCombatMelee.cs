using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCombatMelee : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnGuard(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            animator.SetBool("Guarding", true);            
        }
        if (value.canceled)
        {
            animator.SetBool("Guarding", false);
        }
    }

    public void OnSlash(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            SetTrigger("Slash");
        }
        if (value.canceled)
        {
            
        }
    }

    public void OnStab(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            SetTrigger("Stab");
        }
        if (value.canceled)
        {

        }
    }

    public void OnBash(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            SetTrigger("Bash");
        }
        if (value.canceled)
        {

        }
    }

    void SetTrigger(string trigger)
    {
        animator.SetTrigger(trigger);
    }
}
