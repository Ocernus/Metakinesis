using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwordPlacement : MonoBehaviour
{
    public GameObject sword;

    public bool equipped;

    public void Drop()
    {
        // Change player graphics and equipped bool
        equipped = false;
        sword.transform.position = transform.position;
        sword.SetActive(true);
        print("attempted drop");
    }

    public void Teleport()
    {
        transform.position = sword.transform.position; // not working
        print("attempted teleport");
        PickUp();//should be done in the attack script
    }

    public void PickUp()
    {
        sword.SetActive(false);
        equipped = true;
        // Change player graphics and equipped bool
        print("attempted pickup");
    }

    public void OnSwordPlacementChangeState(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (equipped) Drop();
            else Teleport();
        }        
    }
}
