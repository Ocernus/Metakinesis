using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Damageable
{
    public int hitPointsMax;
    public int hitPointsCurrent;
    public int livesMax;
    public int livesCurrent;
    public int regenAmplitude;
    public int regenFrequency;

    void Start()
    {
        InitializeHealth();
        UpdateUI();
    }

    void Update()
    {
        
    }

    void InitializeHealth()
    {
        hitPointsCurrent = hitPointsMax;
        livesCurrent = livesMax;
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        if (hitPointsCurrent > 0)
        {
            hitPointsCurrent -= Mathf.Min(hitPointsCurrent, amount);
            if (hitPointsCurrent <= 0)
            {
                if (livesCurrent > 0)
                {
                    hitPointsCurrent = hitPointsMax;
                    livesCurrent -= 1;
                }
                else print("player died");
            }            
        }

        UpdateUI();
    }

    public void RestoreHitPoints()
    {
        hitPointsCurrent = hitPointsMax;
        UpdateUI();
    }

    void UpdateUI()
    {
        UIHealthManager.instance.UpdateHealthUI(hitPointsCurrent, livesCurrent);
    }
}
