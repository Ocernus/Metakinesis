using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour 
{
    /*
    ITEM INDEX HELPER
    money      = 0
    bottles    = 1
    potion     = 2
    sanity-    = 3
    sanity+    = 4

    */

    public ItemAbility[] itemAbilities;
    private ItemAbility activeItem;

    public Dictionary<int, int> items = new Dictionary<int, int>();

    public bool swordEquipped;

    public int[] itemIndices;
    
    public static Inventory instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        InitializeInventory();
        activeItem = itemAbilities[0];
    }

    void InitializeInventory()
    {
        for (int i = 0; i < itemIndices.Length; i++)
        {
            items.Add(i, itemIndices[i]);
            UpdateUI(i, items[i]);
        }
    }

    public void ChangeItemCount(int index, int amount)
    {
        int newValue = items[index] + amount;

        items[index] = newValue;
        UpdateUI(index, newValue);
        print("item " + index + " + " + amount);
    }

    void UpdateUI(int index, int value)
    {
        UIAbilityManager.instance.RefreshItemCount(value);
    }

    public void OnPlayerItemAbiltyUse(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            activeItem.Use();
        }
    }
}
