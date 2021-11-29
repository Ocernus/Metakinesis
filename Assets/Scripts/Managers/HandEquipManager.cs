using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandEquipManager : MonoBehaviour
{
    // This script is meant as a manger to control cycling through equipment with the dpad, and specifying what action to perform depending on what is equipped.

    // Basic needs: 
    // Input will control active right and left weapons by indexing through arrays. (dpad L and R)
    // Input will call a function based on if weapons are active or pick-ups are nearby. (L and R triggers)

    public bool[] ownedLeftHandEquips;
    private int activeIndexLeft;

    public bool[] ownedRightHandEquips;
    private int activeIndexRight;

    private void Start()
    {
        UIHandEquipManager.instance.SetLeftIcon(activeIndexLeft);
        UIHandEquipManager.instance.SetRightIcon(activeIndexRight);
    }


    public void CycleLeftEquip(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (activeIndexLeft < ownedLeftHandEquips.Length) activeIndexLeft += 1;
            else activeIndexLeft = 0;
            UIHandEquipManager.instance.SetLeftIcon(activeIndexLeft);
        }
        
    }

    public void CycleRightEquip(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (activeIndexRight < ownedRightHandEquips.Length) activeIndexRight += 1;
            else activeIndexRight = 0;
            UIHandEquipManager.instance.SetRightIcon(activeIndexRight);
        }
    }

    public void UseLeftEquip(InputAction.CallbackContext value)
    {
        switch (activeIndexLeft)
        {
            case 0://none
                {
                    if (value.started)
                    {
                        print("empty");
                    }
                    
                }
                break;
            case 1://sword
                {
                    if (value.started)
                    {
                        GetComponent<SwordAttack>().Attack();
                    }
                    
                }
                break;
            case 2://fireball
                {
                    GetComponentInChildren<Shoot>().OnShoot(value);

                }
                break;
        }
        
    }

    public void UseRightEquip(InputAction.CallbackContext value)
    {
        switch (activeIndexRight)
        {
            case 0://none
                {
                    if (value.started)
                    {
                        print("empty");
                    }
                    
                }
                break;
            case 1://shield
                {
                    if (value.started)
                    {
                        print("bash");
                    }
                    
                }
                break;
            case 2://fireball
                {
                    GetComponentInChildren<Shoot>().OnShoot(value);
                }
                break;
        }
        
    }

}
