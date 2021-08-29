using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAbility : MonoBehaviour
{
    public void Use()
    {
        if (CheckReq())
        {
            PerformAbility();
        }
        else
        {
            AbilityFailed();
        }
    }

    public virtual bool CheckReq()
    {
        return false;
    }

    public virtual void PerformAbility()
    {

    }

    public virtual void AbilityFailed()
    {

    }
}
