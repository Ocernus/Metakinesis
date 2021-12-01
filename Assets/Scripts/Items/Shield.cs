using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject shieldBone;
    public GameObject shieldEnergy;
    public GameObject shieldMetal;

    public float scaleChange;
    public float scaleMax;
    public float scaleMin;
    public float retractionSpeed;

    public bool shouldProject;
    public bool shouldRetract;

    private void Start()
    {
        
        shieldBone.transform.localScale *= scaleMin;
    }

    private void Update()
    {
        if (shouldProject)
        {            
            if (shieldBone.transform.localScale.magnitude >= scaleMax) shouldProject = false;
            else shieldBone.transform.localScale *= scaleChange;
        }
        if (shouldRetract)
        {            
            if (shieldBone.transform.localScale.magnitude <= scaleMin) shouldRetract = false;
            else shieldBone.transform.localScale *= 1 / scaleChange;
        }
    }

    public void ProjectShield()
    {
        shieldBone.SetActive(true);
    }

    IEnumerator Disabler()
    {
        yield return new WaitForSeconds(retractionSpeed);
        shieldBone.SetActive(false);
    }
}
