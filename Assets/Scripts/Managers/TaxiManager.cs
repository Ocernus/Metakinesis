using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiManager : MonoBehaviour
{
    public GameObject[] taxiHubs;

    public static TaxiManager instance;

    private void Awake()
    {
        instance = this;
    }
}
