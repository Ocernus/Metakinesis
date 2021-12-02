using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject shieldBone;
    public GameObject shieldEnergy;
    public GameObject shieldMetal;

    public float scaleUpChange;
    public float scaleMax;
    public float scaleDownChange;
    public float scaleMin;

    public float fluctuation;


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
            if (shieldBone.transform.localScale.magnitude >= scaleMax)
            {
                shieldBone.transform.localScale = new Vector3(1, 1, 1);
                shouldProject = false;
            }
            else shieldBone.transform.localScale *= scaleUpChange;
        }
        if (shouldRetract)
        {            
            if (shieldBone.transform.localScale.magnitude <= scaleMin)
            {
                shieldBone.transform.localScale = new Vector3(scaleMin, scaleMin, scaleMin);
                shouldRetract = false;
            }
            else shieldBone.transform.localScale *= 1 / scaleDownChange;
        }
    }
}
