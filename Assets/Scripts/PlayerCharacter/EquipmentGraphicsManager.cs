using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentGraphicsManager : MonoBehaviour
{
    public GameObject[] heldSwordParts;
    public GameObject[] sheathedSwordParts;
    public GameObject[] fullArmorUpgrades;

    public bool swordHeld;
    public bool armorComplete;

    public bool triggerRefresh;

    void Update()
    {
        if (triggerRefresh)
        {
            ShowSword(swordHeld);

            if (armorComplete)
            {
                foreach (GameObject obj in fullArmorUpgrades) obj.SetActive(true);
            }
            else
            {
                foreach (GameObject obj in fullArmorUpgrades) obj.SetActive(false);
            }

            triggerRefresh = false;
        }        
    }

    public void ShowSword(bool toggle)
    {
        foreach (GameObject obj in heldSwordParts) obj.SetActive(toggle);
        foreach (GameObject obj in sheathedSwordParts) obj.SetActive(!toggle);
    }
}
