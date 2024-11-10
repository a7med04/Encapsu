using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car 
{
    public string name = "Kia";
    public string model = "2030";
    public string color = "Black";
    public int speed = 0;
    public bool engineOn = false;

    public void SwitchOn(){
        engineOn = true;
        Debug.Log("Car Turned On");
    }

    public void SwitchOff(){
        engineOn = false;
        Debug.Log("Car Turned Off");
    }

    public void Banzeen(int value){
        speed += value;
    }

    public void Break(){
        speed = 0;
    }

    public int SpeedoMeter(){
        return speed;
    }


    public void Start()
    {
        
    }

   
}
