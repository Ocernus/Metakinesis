using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emitter : MonoBehaviour
{
    public bool powered;

    public Receiver[] receivers;

    private void Start()
    {
        InitializeDevice();
    }

    public void ToggleState()
    {
        powered = !powered;
        foreach (Receiver receiver in receivers)
        {
            receiver.ChangeState(powered);
        }
    }

    void InitializeDevice()
    {
        foreach (Receiver receiver in receivers)
        {
            receiver.ChangeState(powered);
        }
    }
}
