using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ppplayer : Character
{
    public Ppplayer(string name, int health)  {  
    }
    public void Heal(int amount){
        Health += amount;
        Debug.Log("The Health Is :" + Health); 
    }
}
