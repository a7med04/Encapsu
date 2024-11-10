using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    private string name = "Zarifeh";
    private int health = 100 ;
    public string Name{
        get{ return name;  }
        set{ name = value; }
    }
    public int Health{
        get {
            if (health > 100)
            {
                health = 100;
            }
            else if (health < 0)
            {
                health = 0;
            }
            return health;
        }
        set {
            health = value;
        }
    }
    public Character(string name, int health){
        this.name = name;
        this.health = health;
    }
    public Character(): this("", 100){}
}
