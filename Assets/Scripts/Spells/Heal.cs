using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Heal : MonoBehaviour
{
    public int cost;
    public float rate;
    public int healValue;
    public bool learned;

    public GameObject healEffect;

    private bool inputHeld;
    private bool clockRunning;

    private PlayerHealth playerHealth;
    private PlayerMagic playerMagic;

    private void Start()
    {
        playerHealth = GetComponentInParent<PlayerHealth>();
        playerMagic = GetComponent<PlayerMagic>();
    }

    private void Update()
    {
        if (inputHeld)
        {
            if (learned)
            {
                if (!clockRunning)
                {
                    StartCoroutine(HealClock());
                }
            }            
        }
    }

    public void OnHeal(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            inputHeld = true;
        }
        if (value.canceled)
        {
            inputHeld = false;
        }
    }

    void PerformHeal()
    {
        if (playerHealth.hitPointsCurrent < playerHealth.hitPointsMax)
        {
            if (playerMagic.magicCurrent >= cost)
            {
                playerHealth.Heal(healValue);
                playerMagic.ChangeValue(-cost);
                //Instantiate(healEffect, transform.position, transform.rotation);
            }
            else print("magic low");
        }
        else print("health full");
    }

    IEnumerator HealClock()
    {
        clockRunning = true;
        PerformHeal();
        yield return new WaitForSeconds(rate);
        clockRunning = false;
    }

    public void Learn()
    {
        learned = true;
    }
}
