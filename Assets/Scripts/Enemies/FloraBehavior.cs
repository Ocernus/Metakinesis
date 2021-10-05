using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloraBehavior : MonoBehaviour
{
    public float fireRate;
    public float range;

    public Transform head;
    public Transform launchPoint;

    public GameObject projectile;
    public GameObject player;

    bool playerInRange;
    bool clockRunning;

    void Start()
    {
        
    }

    void Update()
    {
        head.LookAt(player.transform);
        playerInRange = Vector3.Distance(transform.position, player.transform.position) < range;

        if (!clockRunning)
        {
            if (playerInRange)
            {
                StartCoroutine(ShootTimer());
            }
            else StopAllCoroutines();
        }
    }

    IEnumerator ShootTimer()
    {
        clockRunning = true;
        yield return new WaitForSeconds(fireRate);
        LaunchProjectile();
        clockRunning = false;
    }

    void LaunchProjectile()
    {
        print("flower cannon shot");
    }
}
