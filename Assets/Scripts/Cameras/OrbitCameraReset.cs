using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class OrbitCameraReset : MonoBehaviour
{
    private CinemachineFreeLook m_FreeLook;

    private void Start()
    {
        m_FreeLook = GetComponent<CinemachineFreeLook>();
    }

    void DisableRecentering()
    {
        m_FreeLook.m_RecenterToTargetHeading.m_enabled = false;
    }

    public void OnPlayerResetOrbitCam(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            m_FreeLook.m_RecenterToTargetHeading.m_enabled = true;
            Invoke("DisableRecentering", m_FreeLook.m_RecenterToTargetHeading.m_RecenteringTime * 2);
        }
    }
}
