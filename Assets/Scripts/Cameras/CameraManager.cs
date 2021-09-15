using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject playerOrbitCam;
    public GameObject targettingCam;
    public GameObject heartRoomCam;

    public static CameraManager instance;

    private void Awake()
    {
        instance = this;
    }
}
