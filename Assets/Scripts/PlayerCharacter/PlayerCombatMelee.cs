using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCombatMelee : MonoBehaviour
{
    private Animator animator;
    private PlayerGuard guard;
    private SwordAttack attack;

    private void Start()
    {
        animator = GetComponent<Animator>();
        guard = GetComponent<PlayerGuard>();
        attack = GetComponent<SwordAttack>();
    }

    public void OnGuard(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            guard.ToggleGuard(true);            
        }
        if (value.canceled)
        {
            guard.ToggleGuard(false);
        }
    }

    public void OnSlash(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            attack.Attack();
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
