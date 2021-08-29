using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetable : MonoBehaviour
{
    public GameObject cameraTarget;
    public Vector2 screenPosition;

    private void Update()
    {
        screenPosition = Camera.main.WorldToScreenPoint(cameraTarget.transform.position);
    }
}
