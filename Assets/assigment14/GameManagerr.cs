using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerr : MonoBehaviour
{
    public Ppplayer player;
    public Enemy enemy;
    void Start()
    {
        player = new Ppplayer("Ahmed", 40);
        enemy = new Enemy("Ali", 80);

        Debug.Log("The Player Name Is :" + player.Name + ", " + "The Health Is :" + player.Health);
        Debug.Log("The Enemy Name Is :" + enemy.Name + ", " + "The Health Is :" + enemy.Health);

        player.Heal(70);
        enemy.Attack(50);
    }
}
