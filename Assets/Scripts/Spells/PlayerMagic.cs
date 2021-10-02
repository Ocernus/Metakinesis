using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagic : MonoBehaviour
{
    public int magicMax;
    public int magicCurrent;

    private void Start()
    {
        magicCurrent = magicMax;
    }

    public void ChangeValue(int value)
    {
        magicCurrent += value;
        UIAbilityManager.instance.UpdateMagicBar((float) magicCurrent / magicMax);
    }
}
