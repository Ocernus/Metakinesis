using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIAbilityManager : MonoBehaviour
{
    public TextMeshProUGUI itemCountText;

    public static UIAbilityManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void RefreshItemCount(int amount)
    {
        itemCountText.text = amount.ToString();
    }
}
