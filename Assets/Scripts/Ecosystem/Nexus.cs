using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nexus : MonoBehaviour
{
    public float mainInterval;
    public int energyPoints;

    public float fieldScaleDelta;
    public float scaleLerpRate;
    public float fieldScaleUpperLimit;

    public float seedlingSpawnRate;
    public int seedlingEnergyLowerLimit;
    public float seedlingSpawnDistance;

    public GameObject influenceField;
    public GameObject particles;
    public GameObject orb;
    public GameObject shell;
    public GameObject seedling;

    private Vector3 fieldScaleBase;
    private float scaleDelta;
    private bool mainTimerRunning;
    private bool shouldUpdateField;

    private void Start()
    {
        fieldScaleBase = influenceField.transform.localScale;        
    }

    void Update()
    {
        if (!mainTimerRunning) StartCoroutine(MainIntervalTimer());UpdateField();
        AttemptSeedlingSpawn();
    }

    // if struck while inactive, it will activate
    // if struck while active, it will output 1 energy crystal per damage dealt
    // if left alone it will affect the environment

        // fluctuate light levels to match lightning bolts

    void UpdateField()
    {                
        if (scaleDelta < fieldScaleUpperLimit)
        {
            scaleDelta = fieldScaleDelta * energyPoints;
            Vector3 newScale = fieldScaleBase * scaleDelta * energyPoints;            
            if (influenceField.transform.localScale != newScale)
            {
                influenceField.transform.localScale = Vector3.Lerp(influenceField.transform.localScale, fieldScaleBase + newScale, scaleLerpRate);
            }
        }
    }

    void AttemptSeedlingSpawn()
    {
        if (energyPoints >= seedlingEnergyLowerLimit)
        {
            StartCoroutine(SeedlingSpawnTimer());
        }
    }

    IEnumerator MainIntervalTimer()
    {
        mainTimerRunning = true;
        yield return new WaitForSeconds(mainInterval);
        mainTimerRunning = false;
        energyPoints += 1;
    }

    IEnumerator SeedlingSpawnTimer()
    {
        yield return new WaitForSeconds(seedlingSpawnRate);
        print("seedling spawn initiated");
    }
}
