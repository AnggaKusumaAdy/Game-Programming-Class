using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter
{
    private string name;
    private int health;
    private int damage;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }

    public void MoveLeft()
    {
        Debug.Log("Move to left");
    }
    public void MoveRight()
    {
        Debug.Log("Move to right");
    }
    public void Jump()
    {
        Debug.Log("Jumping");
    }
    public void Attack()
    {
        Debug.Log("Attacking");
    }
}



