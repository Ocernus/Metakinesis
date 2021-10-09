using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIAbilityManager : MonoBehaviour
{
    public GameObject swordIcon;
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

    public void ChangeSwordUIState(bool toggle)
    {
        swordIcon.SetActive(toggle);
    }
}
