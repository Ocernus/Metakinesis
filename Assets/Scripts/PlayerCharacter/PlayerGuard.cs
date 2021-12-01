using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerGuard : MonoBehaviour
{
    public float swingOffsetTime;

    Animator anim;
    EquipmentGraphicsManager equip;
    public Shield shield;

    private void Start()
    {
        anim = GetComponent<Animator>();
        equip = GetComponent<EquipmentGraphicsManager>();
    }

    public void OnGuard(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            anim.SetBool("Guarding", true);
            anim.SetBool("Offset Swing", true);
            equip.EquipShield(true);
            if (!shield.shouldProject) shield.shouldProject = true;
            equip.ShowSword(true);//new
        }

        if (value.canceled)
        {
            anim.SetBool("Guarding", false);
        }
    }
}
