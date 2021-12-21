using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIButtonManager : MonoBehaviour
{
    public TextMeshProUGUI southText;
    string southTextDefaultString;

    public TextMeshProUGUI eastText;
    string eastTextDefaultString;

    public TextMeshProUGUI westText;
    string westTextDefaultString;

    public TextMeshProUGUI northText;
    string northTextDefaultString;

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
        SetAllDefaultStrings();
    }

    private void Start()
    {
        ResetAllButtonTexts();
    }

    void SetAllDefaultStrings()
    {
        southTextDefaultString = southText.text;
        eastTextDefaultString = eastText.text;
        westTextDefaultString = westText.text;
        northTextDefaultString = northText.text;
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
        if (contextExists)westText.text = context;
        else westText.text = westTextDefaultString;
    }

    public void RefreshNorthText(bool contextExists, string context)
    {
        if (contextExists) northText.text = context;
        else northText.text = northTextDefaultString;
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
