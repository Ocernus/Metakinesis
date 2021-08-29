using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifetimeLimiter : MonoBehaviour
{
    public float maxLifetime;

    private void OnEnable()
    {
        Destroy(gameObject, maxLifetime);
    }
}
