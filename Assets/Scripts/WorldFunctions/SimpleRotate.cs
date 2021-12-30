using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    public Vector3 rotation;

    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(rotation);
    }
}
