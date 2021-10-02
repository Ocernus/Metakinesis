using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpellBook : MonoBehaviour
{
    public Spell[] spells;
    private Spell activeSpell;

    private bool shootHeld;

    private void Start()
    {
        activeSpell = spells[0];
    }

    public void LearnSpell(int index)
    {
        spells[index].learned = true;
        print("learned " + spells[index].spellName);
    }

    public void OnPlayerSpellAbiltyUse(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            if (activeSpell.learned) activeSpell.Use();
        }
    }

    public void OnShoot(InputAction.CallbackContext value)
    {
        if (spells[0].learned)
        {
            if (value.started)
            {
                
            }
            if (value.canceled)
            {
                spells[0].Use();
            }
        }        
    }
}
