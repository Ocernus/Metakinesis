using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CombatMode : MonoBehaviour
{
    public float sheathTimeMax;
    private float sheathTimeCurrent;
    private bool sheathTimerRunning;
    public Shield shield;
    Animator anim;
    EquipmentGraphicsManager equipGraphics;

    private void Start()
    {
        anim = GetComponent<Animator>();
        equipGraphics = GetComponent<EquipmentGraphicsManager>();
    }

    private void Update()
    {
        if (sheathTimerRunning)
        {
            if (sheathTimeCurrent >= sheathTimeMax)
            {
                ResetSheathTimer();
            }
            else sheathTimeCurrent += Time.deltaTime;
        }
    }

    public void SheathWeapons(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            anim.SetTrigger("Sheath Weapons");
            shield.shouldRetract = true;
            sheathTimerRunning = true;
        }
    }

    void ResetSheathTimer()
    {
        sheathTimerRunning = false;
        sheathTimeCurrent = 0;
        equipGraphics.ShowSword(false);
    }
}
