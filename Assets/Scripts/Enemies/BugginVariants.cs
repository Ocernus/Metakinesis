using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugginVariants : MonoBehaviour
{
    public enum Variants
    {
        basic,
        fighter1,
        fighter2,
        knight,
        mage
    }

    public Variants variant;

    public GameObject maskMandibles;
    public GameObject maskArmored;
    public GameObject maskHooded;

    public GameObject armorShoulder;
    public GameObject armorForearm;
    public GameObject armorHips;
    public GameObject armorLegs;

    public GameObject sleeves;
    public GameObject gutArmor;

    public GameObject shieldFrame;
    public GameObject shieldPanelsA;
    public GameObject shieldPanelsB;

    public GameObject spearShaft;
    public GameObject spearHead;

    public GameObject crusherHandle;
    public GameObject crusherBlade;

    public GameObject wings;

    GameObject[] components = new GameObject[17];

    void Start()
    {
        CollectComponents();
        ClearAll();
        SetVariant(variant);
    }

    void Update()
    {

    }

    public void CollectComponents()
    {
        components[0] = maskMandibles;
        components[1] = maskArmored;
        components[2] = maskHooded;

        components[3] = armorShoulder;
        components[4] = armorForearm;
        components[5] = armorHips;
        components[6] = armorLegs;

        components[7] = sleeves;
        components[8] = gutArmor;

        components[9] = shieldFrame;
        components[10] = shieldPanelsA;
        components[11] = shieldPanelsB;

        components[12] = spearShaft;
        components[13] = spearHead;

        components[14] = crusherHandle;
        components[15] = crusherBlade;

        components[16] = wings;
    }

    public void ClearAll()
    {
        foreach (GameObject g in components) g.SetActive(false);
    }

    public void SetVariant(Variants newVar)
    {
        switch (newVar)
        {
            case Variants.basic:
                {
                    ActivateBasicKit();
                }
                break;
            case Variants.fighter1:
                {
                    ActivateFighter1Kit();
                }
                break;
            case Variants.fighter2:
                {
                    ActivateFighter2Kit();
                }
                break;
            case Variants.knight:
                {
                    ActivateKnightKit();
                }
                break;
            case Variants.mage:
                {
                    ActivateMageKit();
                }
                break;
        }
    }

    void ActivateBasicKit()
    {
        components[0].SetActive(true);
        components[12].SetActive(true);
        components[13].SetActive(true);
    }

    void ActivateFighter1Kit()
    {
        components[0].SetActive(true);
        components[12].SetActive(true);
        components[13].SetActive(true);
        components[9].SetActive(true);
        components[10].SetActive(true);
    }

    void ActivateFighter2Kit()
    {
        components[0].SetActive(true);
        components[12].SetActive(true);
        components[13].SetActive(true);
        components[9].SetActive(true);
        components[10].SetActive(true);
        components[11].SetActive(true);
    }

    void ActivateKnightKit()
    {
        components[1].SetActive(true);
        components[3].SetActive(true);
        components[4].SetActive(true);
        components[5].SetActive(true);
        components[6].SetActive(true);
        components[8].SetActive(true);
        components[14].SetActive(true);
        components[15].SetActive(true);
    }

    void ActivateMageKit()
    {
        components[2].SetActive(true);
        components[7].SetActive(true);
        components[16].SetActive(true);
    }
}
