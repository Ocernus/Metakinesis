using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour 
{
    /*
    
    ITEM INDEX HELPER

    herb     = 0 //  
    fungus   = 1 //
    fruit    = 2 //

    potion   = 3
    poison   = 4
    oil      = 5

    secret   = 6
    dread    = 7
    remnant  = 8

    coin     = 9
    scrap    = 10
    gemstone = 11

    */

    public ItemAbility[] itemAbilities;
    private ItemAbility activeItem;

    public Dictionary<int, int> items = new Dictionary<int, int>();

    public bool swordEquipped;
    public bool shieldEquipped;

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
        //print("item " + index + " + " + amount);
    }

    void UpdateUI(int index, int value)
    {
        UIPickupDisplayManager.instance.RefreshItemCount(index, value);
        /*
        switch (index)
        {
            case 0:
                {
                    UIPickupDisplayManager.instance.RefreshCoins(value);
                }
                break;
            case 1:
                {

                }
                break;
            case 2:
                {

                }
                break;
            case 3:
                {

                }
                break;
            case 4:
                {

                }
                break;
            case 5:
                {
                    UIPickupDisplayManager.instance.RefreshIngots(value);
                }
                break;
            case 6:
                {
                    UIPickupDisplayManager.instance.RefreshCrystals(value);
                }
                break;
                
        }
        */
    }

    public void OnPlayerItemAbiltyUse(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            activeItem.Use();
        }
    }
}
