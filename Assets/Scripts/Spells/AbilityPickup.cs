using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityPickup : MonoBehaviour
{
    public int index;

    public GameObject soundObject;

    private void OnTriggerEnter(Collider other)
    {
        switch (index)
        {
            case 0:
                {
                    Shoot shoot = other.gameObject.GetComponentInChildren<Shoot>();
                    if (shoot)
                    {
                        shoot.Learn();
                        Instantiate(soundObject, transform.position, transform.rotation);
                        Destroy(gameObject);
                    }
                }
                break;
            case 1:
                {
                    Heal heal = other.gameObject.GetComponentInChildren<Heal>();
                    if (heal)
                    {
                        heal.Learn();
                        Instantiate(soundObject, transform.position, transform.rotation);
                        Destroy(gameObject);
                    }
                }
                break;
        }
        
    }

    public virtual void Collect()
    {

    }
}
