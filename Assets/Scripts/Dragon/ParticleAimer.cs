using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAimer : MonoBehaviour
{
    private void Update()
    {
        transform.LookAt(Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 100000f)));
    }
}
