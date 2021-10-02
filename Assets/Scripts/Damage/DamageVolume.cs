using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageVolume : MonoBehaviour
{
    public int damage;
    public GameObject owner;
    public bool dieOnImpact;
    public GameObject impactEffect;

    private void OnTriggerEnter(Collider other)
    {
        Damageable damageable = other.GetComponent<Damageable>();
        if (damageable)
        {
            if (other.gameObject != owner)
            {
                //print("hit " + other.gameObject.name);
                damageable.TakeDamage(damage);
                SpecialHitEffect();
            }            
        }  
        if (dieOnImpact && other.gameObject != owner)
        {
            SelfDestruct();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (dieOnImpact && collision.gameObject != owner)
        {
            SelfDestruct();
        }
    }

    void SelfDestruct()
    {
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public virtual void SpecialHitEffect()
    {

    }
}
