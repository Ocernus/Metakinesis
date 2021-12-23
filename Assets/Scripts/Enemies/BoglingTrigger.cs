using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoglingTrigger : MonoBehaviour
{
    public BoglingBehavior[] boglings;

    private void OnTriggerEnter(Collider other)
    {
        PlayerInteraction player = other.GetComponent<PlayerInteraction>();
        if (player)
        {
            foreach(BoglingBehavior bb in boglings)bb.TriggerAmbush();
        }
    }
}
