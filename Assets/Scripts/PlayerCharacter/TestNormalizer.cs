using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNormalizer : MonoBehaviour
{
    public GameObject player;
    GameObject hitObj;
    int layerMask = 1 << 9;

    void Update()
    {
        transform.position = player.transform.position;
        
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1.0f, layerMask))
        {
            hitObj = hit.transform.gameObject;
            transform.up = hit.normal;
        }
    }
}
