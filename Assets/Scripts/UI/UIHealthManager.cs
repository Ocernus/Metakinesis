using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthManager : MonoBehaviour
{
    public Slider hitPointSlider;
    public GameObject[] lifeBlocks;

    public static UIHealthManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void UpdateHealthUI(int sliderValue, int lifeValue)
    {
        hitPointSlider.value = sliderValue;
        for (int i = 0; i < lifeBlocks.Length; i++)
        {
            if (i < lifeValue)
            {
                lifeBlocks[i].SetActive(true);
            }
            else lifeBlocks[i].SetActive(false);
        }
    }
}
