using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCode : MonoBehaviour {


    private int health;
    private int damage;
    private string type;


	public EnemyCode(int health, int damage, string type)
    {
        this.health = health;
        this.damage = damage;
        this.type = type;
    }


}
