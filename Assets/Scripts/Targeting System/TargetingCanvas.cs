using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingCanvas : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void Show(Transform target)
    {
        SetTarget(target);
        gameObject.SetActive(true);
    }

    public void Hide(Transform target)
    {
        gameObject.SetActive(false);
        SetTarget(target);
    }

    private void SetTarget(Transform target)
    {
        transform.position = target.position;
    }
}
