using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwordAttack : MonoBehaviour
{
    public float sheathTimeMax;
    private float sheathTimeCurrent;
    private bool sheathTimerRunning;

    public float moveLockTimeMax;
    private float moveLockTimeCurrent;
    private bool moveLockTimerRunning;

    public float damageTimeMax;
    public float damageTimeMid;
    private float damageTimeCurrent;
    private bool damageTimerRunning;

    public GameObject slashAttackVolume;

    public AudioSource swordSwingSound;

    EquipmentGraphicsManager equipGraphics;
    Animator anim;
    Movement movement;

    private void Start()
    {
        anim = GetComponent<Animator>();
        equipGraphics = GetComponent<EquipmentGraphicsManager>();
        movement = GetComponent<Movement>();
        slashAttackVolume.SetActive(false);
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
    }

    public void OnCharacterAttack(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (movement.state == Movement.States.onGround)
            {
                anim.SetTrigger("Slash");
                swordSwingSound.Play();
                sheathTimerRunning = true;
                sheathTimeCurrent = 0;
                moveLockTimerRunning = true;
                moveLockTimeCurrent = 0;
                damageTimerRunning = true;
                damageTimeCurrent = 0;

                equipGraphics.ShowSword(true);
                movement.movementMultiplier = 0;
                slashAttackVolume.SetActive(false);
            }            
        }
    }

    void ResetSheathTimer()
    {
        sheathTimerRunning = false;
        sheathTimeCurrent = 0;
        equipGraphics.ShowSword(false);
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

    public void ExternalReset()
    {
        ResetSheathTimer();
        ResetMoveLockTimer();
        ResetDamageTimer();
    }
}
