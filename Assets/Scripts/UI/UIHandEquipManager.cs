using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIHandEquipManager : MonoBehaviour
{
    public GameObject[] leftIcons;
    public GameObject[] rightIcons;

    public static UIHandEquipManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void SetLeftIcon(int index)
    {
        foreach (GameObject g in leftIcons) g.SetActive(false);
        leftIcons[index].SetActive(true);
        
    }

    public void SetRightIcon(int index)
    {
        foreach (GameObject g in rightIcons) g.SetActive(false);
        rightIcons[index].SetActive(true);

    }
}
