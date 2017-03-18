using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList {

    private static ArrayList list;

    public ItemList()
    {
        list = new ArrayList();
        initializeList();
    }



    private void initializeList()
    {
        list.Add(new Item("sword", 30, 5, "weapon", "A short, durable steel sword. The blade is slightly dull.", true));
        list.Add(new Item("dagger", 10, 3, "weapon", "A small dagger. There is an engraving on the handle in\n"
                + " a language you don't recognize.", true));
        list.Add(new Item("crate", 150, 0, "storage", "A sealed wooden box. What do goblins have to store?", false));


    }



    public Item getItemByName(string input)
    {
        Item item = null;
        foreach (Item current in list)
        {
            if (current.getName().Equals(input))
            {
                item = current;
            }
        }
        return item;

    }

}

