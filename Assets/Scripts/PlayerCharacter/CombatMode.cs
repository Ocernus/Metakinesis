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

    bool engaged;

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

    

    void ResetSheathTimer()
    {
        sheathTimerRunning = false;
        sheathTimeCurrent = 0;
        equipGraphics.ShowSword(false);
    }
}
