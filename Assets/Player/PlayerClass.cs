using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass {

    private Inventory inv;
    private int health;
    public int mana;
 
    public PlayerClass () {
        inv = new Inventory();
        health = 100;
        giveStartingItems();
    }


    public void damageHealth(int ammount)
    {
        health -= ammount;
    }

    public void addHealth(int ammount)
    {
        health += ammount;
    }

    public int getHealth()
    {
        return health;
    }

    public void addMana(int ammount)
    {
        mana += ammount;
    }

    public void subtractMana(int ammount)
    {
        mana -= ammount;
    }

    public int getMana()
    {
        return mana;
    }

    private void giveStartingItems()
    {
        inv.addItemByName("sword");
        
    }

}
