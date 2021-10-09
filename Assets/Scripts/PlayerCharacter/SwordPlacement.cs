using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwordPlacement : MonoBehaviour
{
    public GameObject sword;

    Movement movement;
    EquipmentGraphicsManager equipGFX;
    SwordAttack attack;

    private void Start()
    {
        movement = GetComponent<Movement>();
        equipGFX = GetComponent<EquipmentGraphicsManager>();
        attack = GetComponent<SwordAttack>();
    }

    public void Drop(Transform dropPoint)
    {
        // Change player graphics and equipped bool
        equipGFX.EquipSword(false);
        Inventory.instance.swordEquipped = false;
        UIAbilityManager.instance.ChangeSwordUIState(false);
        sword.transform.position = dropPoint.position;
        sword.SetActive(true);
        print("attempted drop");
    }

    public void Teleport()
    {
        movement.PausePlayerControl();
        transform.position = sword.transform.position; // not working
        print("attempted teleport");
        PickUp();//should be done in the attack script
        movement.ReturnPlayerControl();
    }

    public void PickUp()
    {
        sword.SetActive(false);
        equipGFX.EquipSword(true);
        Inventory.instance.swordEquipped = true;
        UIAbilityManager.instance.ChangeSwordUIState(true);
        // Change player graphics and equipped bool
        print("attempted pickup");
    }

    public void ExternalPositionSet(Vector3 position)
    {
        equipGFX.EquipSword(false);
        Inventory.instance.swordEquipped = false;
        sword.transform.position = position;
        sword.SetActive(true);
    }
    /*
    public void OnSwordPlacementChangeState(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (Inventory.instance.swordEquipped) Drop();
            else Teleport();
        }        
    }
    */
}
