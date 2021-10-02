using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public bool learned;
    bool inputHeld;
    float chargeValue;
    public int cost;

    public GameObject projectile;
    public Transform launchPoint;
    public AudioSource chargeSound;
    private PlayerMagic magic;

    private void Start()
    {
        magic = GetComponent<PlayerMagic>();
    }

    private void Update()
    {
        if (inputHeld) chargeValue += Time.deltaTime;
        else chargeValue = 0;
    }

    public void OnShoot(InputAction.CallbackContext value)
    {
        if (learned)
        {
            if (magic.magicCurrent >= cost)
            {
                
                if (value.started)
                {
                    magic.ChangeValue(-cost);
                    Charge();
                    if (!chargeSound.isPlaying) chargeSound.Play();
                }
                if (value.canceled)
                {
                    Release();
                    if (chargeSound.isPlaying) chargeSound.Stop();
                }
            }            
        }
    }

    void Charge()
    {
        if (!inputHeld) inputHeld = true;
    }

    void Release()
    {
        inputHeld = false;
        print(chargeValue);
        MakeProjectile();
    }

    void MakeProjectile()
    {
        GameObject obj = Instantiate(projectile, launchPoint.position, launchPoint.rotation);
        obj.GetComponent<DamageVolume>().owner = transform.parent.gameObject;
    }

    public void Learn()
    {
        learned = true;
    }
}
