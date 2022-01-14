using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingManager : MonoBehaviour
{
    
    public GameObject targetBuddy;

    public float range;

    public Targetable activeTarget;

    public Movement movement;
    public TargetingCameraControl cam;
    public TargetingCanvas canv;    

    private List<Transform> targets;
    private Transform closestTarget;
    private int targetCount;

    private bool foundTarget;
    private bool state;

    public static TargetingManager instance;
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        TargetSphere();
    }

    public void LockOnToggle()
    {
        state = !state;
        if (state)
        {
            if (foundTarget)
            {
                cam.EngageLockOn(activeTarget.cameraTarget.transform);
                movement.LockRotation();
                canv.Show(activeTarget.cameraTarget.transform);
            }            
        }

        if (!state)
        {
            CancelLockOn();
        }
    }

    private void TargetSphere()
    {
        Collider[] detector = Physics.OverlapSphere(transform.position, range);
        targets = new List<Transform>();
        foreach (Collider col in detector)
        {
            Targetable target = col.GetComponent<Targetable>();
            if (target != null) targets.Add(col.transform);
        }
        targetCount = targets.Count;
        if (targetCount != 0)
        {
            FindClosestTarget();
        }
        if (targetCount == 0)
        {
            if (foundTarget) CancelLockOn();
        }
        
    }

    private void FindClosestTarget()
    {
        float closest = range;
        closestTarget = null;
        for (int i = 0; i < targetCount; i++)
        {
            float distanceToPlayer = Vector3.Distance(targets[i].position, transform.position);
            if (distanceToPlayer < closest)
            {
                closest = distanceToPlayer;
                closestTarget = targets[i];
            }
        }
        if (closestTarget)
        {
            SetActiveTarget(closestTarget);
            foundTarget = true;
        }
    }

    private void SetActiveTarget(Transform priority)
    {
        activeTarget = priority.GetComponent<Targetable>();
    }

    void CancelLockOn()
    {
        cam.CancelLockOn();
        movement.UnlockRotation();
        canv.Hide(movement.transform);
        foundTarget = false;
        activeTarget = null;
    }
}
