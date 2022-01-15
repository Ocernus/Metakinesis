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

    bool guarding;

    private void Start()
    {
        anim = GetComponent<Animator>();
        equip = GetComponent<EquipmentGraphicsManager>();
    }

    public void ToggleGuard(bool guarding)
    {
        if (guarding)
        {
            anim.SetBool("Guarding", true);
            anim.SetBool("Offset Swing", true);
            equip.EquipShield(true);
            if (!shield.shouldProject) shield.shouldProject = true;
            equip.ShowSword(true);//new
        }

        if (!guarding)
        {
            anim.SetBool("Guarding", false);
        }
    }
}
