using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagic : MonoBehaviour
{
    public int magicMax;
    public int magicCurrent;

    public int stepsToRecharge;
    public int stepRechargeAmount;
    private int stepTemp;

    public int hitRechargeAmount;

    private Movement movement;

    private void Start()
    {
        magicCurrent = magicMax;
        movement = GetComponentInParent<Movement>();
    }

    public void ChangeValue(int value)
    {
        magicCurrent += value;
        UIAbilityManager.instance.UpdateMagicBar((float) magicCurrent / magicMax);
    }

    public void SolveStepCount(int value)
    {
        if (stepTemp < stepsToRecharge)
        {
            stepTemp += value;
        }
        else
        {
            if (magicCurrent < magicMax) ChangeValue(Mathf.Min(magicMax - magicCurrent, stepRechargeAmount));
            stepTemp = 0;
        }
    }

    public void SolveHitReturns()
    {
        if (magicCurrent < magicMax) ChangeValue(Mathf.Min(magicMax - magicCurrent, hitRechargeAmount));
    }

    public void SolveCollectionReturns(int value)
    {
        if (magicCurrent < magicMax) ChangeValue(Mathf.Min(magicMax - magicCurrent, value));
    }
}
