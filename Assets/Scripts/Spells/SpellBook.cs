using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpellBook : MonoBehaviour
{
    public Spell[] spells;
    private Spell activeSpell;

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
            activeSpell.Use();
        }
    }
}
