using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        void Start()
        {
            Action logMessage = () => Debug.Log("Hello from Action delegate!");
            logMessage();

            Func<int, int> square = (int a) => (a * a);
            Debug.Log($"Square: {square(5)}");

            Predicate<int> isEven = (int a) => a % 2 == 0 ? true : false;
            Debug.Log($"Is 4 even? {isEven(4)}");
        }
    }
}