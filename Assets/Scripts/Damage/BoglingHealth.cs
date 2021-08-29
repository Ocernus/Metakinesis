using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoglingHealth : Damageable
{
    public int maxHits;
    public float flinchTime;
    public float deathTime;
    public GameObject particle;
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
        if (particle) Instantiate(particle, transform.position, transform.rotation);
        anim.SetTrigger("Damage");

        if (maxHits <= 0)
        {
            behavior.HaltAllAction();
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
