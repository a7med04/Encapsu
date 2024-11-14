using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOverriding : MonoBehaviour
{
    Animal animal;
    Cat cat;
    Kitten kitten;
    Animal[] animals = new Animal[3];
    void Start()
    {
        animal = new Animal();
        cat = new Cat();
        kitten = new Kitten();

        animals[0] = animal;
        animals[1] = cat;
        animals[2] = kitten;

        // animal.MakeSound();
        // cat.MakeSound();
        // kitten.MakeSound();

        for(int i = 0; i < animals.Length; i++){
            // Animal animal = animals[i];
            // animal.MakeSound();

            animals[i].MakeSound();
        }
}   
}
