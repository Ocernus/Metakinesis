using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TargetingCameraControl : MonoBehaviour
{    
    private CinemachineVirtualCamera cam;

    private void Awake()
    {
        cam = GetComponent<CinemachineVirtualCamera>();
        gameObject.SetActive(false);
        cam.enabled = true;
    }  

    public void EngageLockOn(Transform target)
    {
        cam.m_LookAt = target;
        gameObject.SetActive(true);
    }

    public void CancelLockOn()
    {
        cam.m_LookAt = null;
        gameObject.SetActive(false);
    }
}
