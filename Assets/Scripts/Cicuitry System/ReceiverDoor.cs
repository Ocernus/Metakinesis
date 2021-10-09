using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiverDoor : Receiver
{
    Animator animator;

    public bool invertInput;
    public bool startOpen;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public override void ChangeState(bool toggle)
    {
        if (invertInput) animator.SetBool("Open", !toggle);
        else animator.SetBool("Open", toggle);
    }
}
