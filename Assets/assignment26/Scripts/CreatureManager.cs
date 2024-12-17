using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assigment26
{
    public class Creature 
    {
        public virtual void Speak(){
            Debug.Log("A creature makes a sound");
        }

    }
    public interface IRunnable{
        public void Run();
    }
    public interface IJumpable{
        public void Jump();
    }
    public interface ISwimmable{
        public void Swim();
    }

    public class Kangaroo : Creature, IRunnable, IJumpable
    { 
        public void Run(){
            Debug.Log("Kangaroo runs");
        }
        public void Jump(){
            Debug.Log("Kangaroo jumps");
        }
        public override void Speak(){
            Debug.Log("Kangaroo says: Hop!");
        }
    }

    public class Duck : Creature, IRunnable, ISwimmable
    { 
        public void Run(){
            Debug.Log("Duck runs");
        }
        public void Swim(){
            Debug.Log("Duck swims");
        }
        public override void Speak(){
            Debug.Log("Duck says: Quack!");
        }
    }

    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();
            List<Creature> creatures = new List<Creature>() {kangaroo, duck};

            List<IRunnable> run = new List<IRunnable>() {(IRunnable)kangaroo, (IRunnable)duck};
            List<IJumpable> jump = new List<IJumpable>() {(IJumpable)kangaroo };
            List<ISwimmable> swim = new List<ISwimmable>() {(ISwimmable)duck };

            foreach (Creature create in creatures){
                create.Speak();
            }

            foreach (IRunnable runnable in run){
                runnable.Run();
            }
            
            foreach (IJumpable jumpable in jump){
                jumpable.Jump();
            }

            foreach (ISwimmable swimmable in swim){
                swimmable.Swim();
            }
        }
    }
}