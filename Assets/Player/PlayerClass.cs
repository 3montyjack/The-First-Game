using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour {

    private Inventory inv;
    // Use this for initialization
    void Start () {
        inv = new Inventory();
        giveItems();
    }

    

    // Update is called once per frame
    void Update () {
        Console.WriteLine(inv.getInventoryNames());
    }

    private void giveItems()
    {
        inv.addItemByName("sword");
        Console.WriteLine("Hello World");
        
    }

}
