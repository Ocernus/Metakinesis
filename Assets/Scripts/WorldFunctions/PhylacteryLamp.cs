using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhylacteryLamp : MonoBehaviour
{
    public GameObject graphics;
    public Vector3 rotation;

    private void Update()
    {
        graphics.transform.Rotate(rotation);
    }
}
