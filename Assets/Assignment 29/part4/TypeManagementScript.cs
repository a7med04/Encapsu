using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment29
{
    public class TypeManagementScript : MonoBehaviour
    {
        void Start()
        {
            Animal cat = new Cat();
            cat.MakeSound();
            cat.Move();

            Cat c = cat as Cat ;
            c.MakeSound();
            c.Move();

            List<ICanFight> fight = new List<ICanFight>();
            fight.Add(new Cat());
            fight.Add(new Warrior());

            foreach(var obj in fight){
                obj.Attack();
            }

            foreach (var obj in fight)
            {
                if (obj is Cat)
                {
                    Debug.Log("The object is a Cat.");
                }

                if (obj is Warrior)
                {
                    Debug.Log("The object is a Warrior.");
                }
            }



        }
    }

    public class Animal
    {
        public virtual void MakeSound(){
            Debug.Log("Animal sound.");
        }

        public void Move(){
            Debug.Log("Animal moves.");
        }

    }

    public class Cat : Animal, ICanFight
    {
        public override void MakeSound(){
            Debug.Log("Meow!");
        }

        public new void Move(){
            Debug.Log("Cat runs quickly.");
        }

        public void Attack(){
            Debug.Log("Cat attacks with claws!");
        }

    }

    public interface ICanFight{
        public void Attack();
    }

    public class Warrior : ICanFight 
    {
        public void Attack(){
            Debug.Log("Warrior attacks with a sword!");
        }
    }
}