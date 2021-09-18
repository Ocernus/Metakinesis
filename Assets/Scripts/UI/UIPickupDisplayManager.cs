using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIPickupDisplayManager : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI ingotsText;
    public TextMeshProUGUI crystalsText;

    public static UIPickupDisplayManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void RefreshCoins(int value)
    {
        coinText.text = value.ToString();
    }

    public void RefreshIngots(int value)
    {
        ingotsText.text = value.ToString();
    }

    public void RefreshCrystals(int value)
    {
        crystalsText.text = value.ToString();
    }
}
