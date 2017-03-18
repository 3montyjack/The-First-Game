using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory {

    Dictionary<Item, int> inv;
    private ItemList list;

    public Inventory () {
        inv = new Dictionary<Item, int>();
        list = new ItemList();
    }

    public void addItemByName(string input)
    {
        addItem(getItemByName(input));
    }

    public Item getItemByName(string input)
    {
        return list.getItemByName(input);
    }



    public void addItem(Item item)
    {
        if (inv.ContainsKey(item))
        {
            Console.WriteLine(item.GetType());
            int currentNumber = (int)inv[item];
            inv.Add(item, currentNumber + 1);
        }
        else
        {
            inv.Add(item, 1);
        }
    }

    public bool removeItem(Item item)
    {
        bool flag = false;
        if (inv.ContainsKey(item))
        {
            int currentNumber = (int)inv[item];
            inv.Add(item, currentNumber - 1);
            if ((int)inv[item] == 0)
            {
                inv.Remove(item);
            }
            flag = true;
        }
        return flag;
    }

    public int getSizeOfInventory()
    {
        return inv.Count;
    }

    public string[] getInventoryNames()
    {
        string[] inventory = new string[inv.Count];
        int index = 0;
        foreach (Item de in inv.Keys.ToArray())
        {
            inventory[index] = de.getName();
            index++;
        }
        return inventory;
    }


}
