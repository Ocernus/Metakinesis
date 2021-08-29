using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCollider : MonoBehaviour
{
    public bool ready;
    public Collider ignoreCollider;

    private List<Collider> colliders = new List<Collider>();

    private void OnTriggerEnter(Collider other)
    {
        if (other != ignoreCollider) colliders.Add(other);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other != ignoreCollider) colliders.Remove(other);
    }

    private void Update()
    {
        ready = colliders.Count > 0;
    }
}
