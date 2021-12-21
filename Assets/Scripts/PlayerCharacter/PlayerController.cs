using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private string actionMapCharacterControl = "Character Control";
    private string actionMapInteractableControl = "Interactable Control";
    private string actionMapMenuControl = "Menu Control";
    private string actionMapFlightControl = "Dragon Controls";

    private PlayerInput playerInput;

    public static PlayerController instance;

    private void Awake()
    {
        instance = this;
        playerInput = GetComponent<PlayerInput>();
    }

    private void Start()
    {
    }

    public void EnableCharacterControl()
    {
        playerInput.SwitchCurrentActionMap(actionMapCharacterControl);
        //print("character control enabled");
    }

    public void EnableInteractableControl()
    {
        playerInput.SwitchCurrentActionMap(actionMapInteractableControl);
        //print("interactable control enabled");
    }

    public void EnableMenuControl()
    {
        playerInput.SwitchCurrentActionMap(actionMapMenuControl);
    }

    public void EnableFlightControls()
    {
        playerInput.SwitchCurrentActionMap(actionMapFlightControl);
    }
}
