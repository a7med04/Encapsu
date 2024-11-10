using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health){  
    }
    public void Attack(int amount){
        Health -= amount; 
        Debug.Log("The Health Is :" + Health);  
    }
}
