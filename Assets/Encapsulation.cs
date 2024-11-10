using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encapsulation : MonoBehaviour
{
    Car ahmedCar = new Car();
    
    void Start()
    {
        ahmedCar.color = "red";
        Debug.Log(ahmedCar.color);

        ahmedCar.Banzeen(50);
        Debug.Log(ahmedCar.speed);

        ahmedCar.Banzeen(20);
        Debug.Log(ahmedCar.speed);

        ahmedCar.Break();
        Debug.Log(ahmedCar.speed);
      
    }
}
