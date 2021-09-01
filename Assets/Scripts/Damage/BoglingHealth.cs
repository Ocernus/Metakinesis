using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoglingHealth : Damageable
{
    public int maxHits;
    public float flinchTime;
    public float deathTime;
    public GameObject particle;
    public AudioSource damageSound;
    public AudioSource deathSound;

    Animator anim;
    BoglingBehavior behavior;

    private void Start()
    {
        anim = GetComponent<Animator>();
        behavior = GetComponent<BoglingBehavior>();
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        maxHits -= amount;
        damageSound.Play();
        if (particle) Instantiate(particle, transform.position, transform.rotation);
        anim.SetTrigger("Damage");

        if (maxHits <= 0)
        {
            behavior.HaltAllAction();
            deathSound.Play();
            Destroy(gameObject, deathTime);
        }
        else StartCoroutine(FlinchTimer());
    }

    IEnumerator FlinchTimer()
    {
        behavior.Flinch(true);
        yield return new WaitForSeconds(flinchTime);
        anim.SetTrigger("Flail");
        behavior.Flinch(false);
    }
}
