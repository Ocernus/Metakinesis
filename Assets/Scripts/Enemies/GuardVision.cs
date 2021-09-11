using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardVision : MonoBehaviour
{
    public float eyeHeight;
    private float visionDotProduct;
    public bool targetCurrentlyVisible;
    public Vector3 targetLastSeenPosition;
    private Vector3 targetDirection;
    public float visionDistance;
    public float targetDistance;
    public GameObject mark;

    public Transform imprisonmentPoint;
    public Transform contrabandPoint;

    private void Update()
    {
        if (Inventory.instance.swordEquipped)
        {
            LookForTarget(PlayerController.instance.gameObject);
        }
        else targetCurrentlyVisible = false;
        mark.SetActive(targetCurrentlyVisible);
        if (targetCurrentlyVisible)
        {
            ImprisonPlayer();
            PlayerController.instance.GetComponent<SwordPlacement>().ExternalPositionSet(contrabandPoint.position);
        }
    }

    public float LookForTarget(GameObject behaviorTarget)
    {
        CheckTargetInFOV(behaviorTarget);
        CheckTargetRaycast(behaviorTarget);
        return FeedbackVisionConfidence();
    }

    void CheckTargetInFOV(GameObject target)
    {
        targetDirection = target.transform.position - transform.position;
        visionDotProduct = Vector3.Dot(transform.forward, targetDirection.normalized);
    }

    public bool TargetWithinRange(float distance)
    {
        return targetDirection.magnitude < distance;
    }

    void CheckTargetRaycast(GameObject target)
    {
        if (visionDotProduct > 0 && TargetWithinRange(visionDistance))
        {
            Debug.DrawRay(transform.position + eyeHeight * transform.up, targetDirection);
            Ray ray = new Ray(transform.position + eyeHeight * transform.up, targetDirection);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, visionDistance))
            {
                if (hit.collider.gameObject == target)
                {
                    targetLastSeenPosition = target.transform.position;
                    targetCurrentlyVisible = true;
                }
                else targetCurrentlyVisible = false;
            }
        }
        else targetCurrentlyVisible = false;
    }

    public float FeedbackVisionConfidence()
    {
        if (targetCurrentlyVisible)
        {
            return (float)System.Math.Round(visionDotProduct, 2);
        }
        else return 0;
    }

    void ImprisonPlayer()
    {
        Movement movement = PlayerController.instance.GetComponent<Movement>();
        movement.PausePlayerControl();
        PlayerController.instance.transform.position = imprisonmentPoint.position;
        movement.ReturnPlayerControl();
    }
}
