using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoglingTrigger : MonoBehaviour
{
    public BoglingBehavior bogling;

    private void OnTriggerEnter(Collider other)
    {
        PlayerInteraction player = other.GetComponent<PlayerInteraction>();
        if (player) bogling.TriggerAmbush();
    }
}
