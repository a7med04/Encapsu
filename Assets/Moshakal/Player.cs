using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public string name = "";
    private int health = 100;
    public int playerExperiance {
        get { return 5; }
        set { playerExperiance = value; }
    }

    public void ChangeName(string playername){
        name = playername;
    }

    public string Playername(){
        return name;
    }

    public void GetDamage(int value){
        health -= value;
    }

    public int HealthAmount(){
        return health;
    }

    public void Heal(int value){
        health += value;
    }
}
