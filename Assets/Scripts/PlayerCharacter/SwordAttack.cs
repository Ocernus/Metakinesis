using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwordAttack : MonoBehaviour
{
    

    public float moveLockTimeMax;
    private float moveLockTimeCurrent;
    private bool moveLockTimerRunning;

    public float damageTimeMax;
    public float damageTimeMid;
    private float damageTimeCurrent;
    private bool damageTimerRunning;

    public float inputTimeMax;
    private float inputTimeCurrent;
    private bool inputTimerRunning;

    public GameObject slashAttackVolume;

    public AudioSource swordSwingSound;

    EquipmentGraphicsManager equipGraphics;
    Animator anim;
    Movement movement;

    public Shield shield;

    private void Start()
    {
        anim = GetComponent<Animator>();
        equipGraphics = GetComponent<EquipmentGraphicsManager>();
        movement = GetComponent<Movement>();
        slashAttackVolume.SetActive(false);
    }

    private void Update()
    {
        

        if (moveLockTimerRunning)
        {
            if (moveLockTimeCurrent >= moveLockTimeMax)
            {
                ResetMoveLockTimer();
            }
            else moveLockTimeCurrent += Time.deltaTime;
        }

        if (damageTimerRunning)
        {
            if (damageTimeCurrent >= damageTimeMax)
            {
                ResetDamageTimer();
            }
            else damageTimeCurrent += Time.deltaTime;

            if (damageTimeCurrent >= damageTimeMid)
            {
                slashAttackVolume.SetActive(true);
            }
        }

        if (inputTimerRunning)
        {
            if (inputTimeCurrent >= inputTimeMax)
            {
                ResetInputTimer();
            }
            else inputTimeCurrent += Time.deltaTime;
        }
    }

    public void Attack()
    {
        if (!inputTimerRunning)
        {/*
            if (movement.state == Movement.States.onGround)
            {*/
                anim.SetTrigger("Slash");
                swordSwingSound.Play();

                inputTimerRunning = true;
                inputTimeCurrent = 0;
                /*sheathTimerRunning = true;
                sheathTimeCurrent = 0;*/
                moveLockTimerRunning = true;
                moveLockTimeCurrent = 0;
                damageTimerRunning = true;
                damageTimeCurrent = 0;
            
            equipGraphics.ShowSword(true);

            shield.shouldProject = true;
                movement.movementMultiplier = 0;
                slashAttackVolume.SetActive(false);/*
            }*/
        }
    }

    

    void ResetMoveLockTimer()
    {
        moveLockTimerRunning = false;
        moveLockTimeCurrent = 0;
        movement.movementMultiplier = 1;
    }

    void ResetDamageTimer()
    {
        damageTimerRunning = false;
        damageTimeCurrent = 0;
        slashAttackVolume.SetActive(false);
    }

    void ResetInputTimer()
    {
        inputTimerRunning = false;
        inputTimeCurrent = 0;
        anim.SetBool("Offset Swing", !anim.GetBool("Offset Swing"));
    }

    public void ExternalReset()
    {
        //ResetSheathTimer();
        ResetMoveLockTimer();
        ResetDamageTimer();
        ResetInputTimer();
    }
}
