using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIAbilityManager : MonoBehaviour
{
    public Image fillImage;

    public static UIAbilityManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void UpdateMagicBar(float value)
    {
        fillImage.fillAmount = value;
    }
}
