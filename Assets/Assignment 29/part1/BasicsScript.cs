using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            var num = 3;
            var name = "Ahmed";
            var qustion = true;

            string evenOrOdd = (num % 2) == 0 ? "Even" : "Odd";
            Debug.Log($"The Number {num} Is {evenOrOdd}");

            Debug.Log(DateTime.Now.Date.Date);
            Debug.Log(DateTime.Now.TimeOfDay);
            Debug.Log(DateTime.Now.DayOfWeek);


        }
        void Update()
        {

        }
    }
}