using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class QuickMenu : MonoBehaviour
{
    private CombatMode combatMode;

    public enum Mode
    {
        neutral,
        combat,
        magic,
        item,
    }

    public Mode mode;

    private void Start()
    {
        combatMode = GetComponent<CombatMode>();
    }

    public void OnToggleWeapons(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (mode == Mode.combat)
            {
                mode = Mode.neutral;
            }
            else
            {
                mode = Mode.combat;
            }
        }
    }
}
