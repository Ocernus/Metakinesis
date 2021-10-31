using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public GameObject shiftableGeometry;

    public static ShipController instance;

    private void Awake()
    {
        instance = this;
    }

    public void ShiftToArchives()
    {
        print("shift to archives");
        shiftableGeometry.transform.Rotate(-90, 0, 0);
    }
     public void ShiftToBridge()
    {
        shiftableGeometry.transform.Rotate(90, 0, 0);
        print("shift to bridge");
    }
}
