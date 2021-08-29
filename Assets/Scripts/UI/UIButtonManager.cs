using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIButtonManager : MonoBehaviour
{
    public TextMeshProUGUI southText;
    public string southTextDefaultString;

    public TextMeshProUGUI eastText;
    public string eastTextDefaultString;

    public TextMeshProUGUI westText;
    public string westTextDefaultString;

    public TextMeshProUGUI northText;
    public string northTextDefaultString;

    public GameObject westRequirementObj;
    public TextMeshProUGUI westRequirementText;
    //public Image westRequirementImage;

    public GameObject northRequirementObj;
    public TextMeshProUGUI northRequirementText;
    //public Image northRequirementImage;


    public static UIButtonManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        ResetAllButtonTexts();
    }

    public void RefreshSouthText(bool contextExists, string context)
    {
        if (contextExists) southText.text = context;
        else southText.text = southTextDefaultString;
    }

    public void RefreshEastText(bool contextExists, string context)
    {
        if (contextExists) eastText.text = context;
        else eastText.text = eastTextDefaultString;
    }

    public void RefreshWestText(bool contextExists, string context)
    {
        if (contextExists)
        {
            westText.text = context;

        }
        else
        {
            westText.text = westTextDefaultString;

        }
    }

    public void RefreshNorthText(bool contextExists, string context)
    {
        if (contextExists)
        {
            northText.text = context;

        }
        else
        {
            northText.text = northTextDefaultString;

        }
    }

    public void ResetAllButtonTexts()
    {
        RefreshEastText(false, "");
        RefreshSouthText(false, "");
        RefreshNorthText(false, "");
        RefreshWestText(false, "");
    }

    public void HideAllButtonTexts()
    {
        RefreshEastText(true, "");
        RefreshSouthText(true, "");
        RefreshNorthText(true, "");
        RefreshWestText(true, "");
    }
}
