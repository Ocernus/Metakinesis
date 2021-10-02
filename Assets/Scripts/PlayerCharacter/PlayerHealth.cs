using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Damageable
{
    public int hitPointsMax;
    public int hitPointsCurrent;
    public int armorMax;
    public int armorCurrent;
    public int regenAmplitude;
    public int regenFrequency;

    public EquipmentGraphicsManager equips;

    public AudioSource damageSound;

    void Start()
    {
        equips = GetComponent<EquipmentGraphicsManager>();
        InitializeHealth();
        InitializeArmor();
        UpdateUI();
    }

    void Update()
    {
        
    }

    void InitializeHealth()
    {
        hitPointsCurrent = hitPointsMax;        
    }

    void InitializeArmor()
    {
        equips.ShowArmor(armorCurrent);
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        if (hitPointsCurrent > 0)
        {
            hitPointsCurrent -= Mathf.Min(hitPointsCurrent, amount);
            damageSound.Play();
            if (hitPointsCurrent <= 0)
            {
                if (armorCurrent > 0)
                {
                    hitPointsCurrent = hitPointsMax;
                    armorCurrent -= 1;
                    equips.ShowArmor(armorCurrent);
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
        UIHealthManager.instance.UpdateHealthUI(hitPointsCurrent, armorCurrent);
    }

    public void IncreaseArmor()
    {
        armorCurrent += 1;
        equips.ShowArmor(armorCurrent);
        UpdateUI();
    }

    public void Heal(int amount)
    {
        hitPointsCurrent += Mathf.Min(hitPointsMax - hitPointsCurrent, amount);
        UpdateUI();
    }
}
