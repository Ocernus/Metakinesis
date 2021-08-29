using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UISpaceConversionDisplay : MonoBehaviour
{
    public TextMeshProUGUI spaceText;

    private void Update()
    {
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        spaceText.text = (screenPos.x + ", " + screenPos.y);
    }
}
