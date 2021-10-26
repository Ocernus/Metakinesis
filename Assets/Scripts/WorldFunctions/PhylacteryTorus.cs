using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhylacteryTorus : MonoBehaviour
{
    public Vector3 rotation;

    private void Update()
    {
        transform.Rotate(rotation);
    }
}
