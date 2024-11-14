using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public class CharacterTest : MonoBehaviour
    {
        Soldier soldier ;
        Officer officer ;
        Character[] characters ;

        void Start()
        {
            soldier = new Soldier();
            officer = new Officer();
            Character[] characters = { soldier, officer };

            for (int i = 0; i < characters.Length; i++){
                characters[i].DisplayInfo();
            }

            Debug.Log("Health Before = " + soldier.Health);
            officer.Attack(40, soldier);
            Debug.Log("Health After = " + soldier.Health);
        }
    }
}
