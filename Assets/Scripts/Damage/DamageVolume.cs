using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageVolume : MonoBehaviour
{
    public int damage;
    public GameObject owner;

    private void OnTriggerEnter(Collider other)
    {
        Damageable damageable = other.GetComponent<Damageable>();
        if (damageable)
        {
            if (other.gameObject != owner)
            {
                print("hit " + other.gameObject.name);
                damageable.TakeDamage(damage);
            }            
        }                
    }
}
