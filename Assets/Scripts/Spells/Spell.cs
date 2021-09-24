using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public string spellName;
    public bool learned;

    public virtual void Use()
    {
        print("cast " + spellName);
    }
}
