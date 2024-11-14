using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
namespace Assignment16
{
    public class Character 
    {
        public string name;
        private int health;
        protected Position position;
        public int Health{
            set {
                if (health > 100){
                    health = 100;
                }
                else if (health < 0)
                {
                    health = 0;
                }
            }
            get{
                return health;
            }
        }
        public Character(string name ,int health, Position position){
            this.name = name;
            this.health = health;
            this.position = position; 
        }
        public Character() : this("A7med", 100, new Position(0,0,0))
        {}
         
        public virtual void DisplayInfo(){
            Debug.Log("Name = " + name);
            Debug.Log("Health = " + Health);
            position.printPosition();
        }

        public void Attack(int damage, Character target ){
            target.health -= damage;
        }

        public void Attack(int damage, Character target, string attackType){
            target.health -= damage;
            Debug.Log("The Attack Type Is " + attackType);
        }
    }
}