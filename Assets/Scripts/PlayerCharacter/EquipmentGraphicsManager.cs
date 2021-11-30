using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentGraphicsManager : MonoBehaviour
{
    public GameObject[] heldSwordParts;
    public GameObject[] sheathedSwordParts;
    public GameObject[] fullArmorUpgrades;
    public GameObject[] sheathParts;
    public GameObject[] armorPieces;
    public GameObject[] shieldPieces;

    public bool swordEquipped;
    public bool swordHeld;
    public bool armorComplete;
    public bool shieldEquipped;
    public bool shieldHeld;

    public bool triggerRefresh;

    
    void Update()
    {
        swordEquipped = Inventory.instance.swordEquipped;
        shieldEquipped = Inventory.instance.shieldEquipped;

        if (triggerRefresh)
        {
            ShowSword(swordHeld);

            

            triggerRefresh = false;
        }        
    }

    public void ShowSword(bool toggle)
    {
        if (swordEquipped)
        {
            foreach (GameObject obj in heldSwordParts) obj.SetActive(toggle);
            foreach (GameObject obj in sheathedSwordParts) obj.SetActive(!toggle);
        }        
        else
        {
            foreach (GameObject obj in heldSwordParts) obj.SetActive(false);
            foreach (GameObject obj in sheathedSwordParts) obj.SetActive(false);
            foreach (GameObject obj in sheathParts) obj.SetActive(false);
        }
    }

    public void EquipSword(bool toggle)
    {
        swordEquipped = toggle;
        foreach (GameObject obj in sheathedSwordParts) obj.SetActive(toggle);
        foreach (GameObject obj in sheathParts) obj.SetActive(toggle);
    }

    public void EquipShield(bool toggle)
    {
        shieldEquipped = toggle;
        foreach (GameObject obj in sheathParts) obj.SetActive(toggle);
    }

    public void ShowArmor(int value)
    {
        foreach (GameObject armor in armorPieces)
        {
            if (System.Array.IndexOf(armorPieces, armor) > value -1)
            {
                armor.SetActive(false);
            }
            else
            {
                armor.SetActive(true);
            }
        }
    }
}
