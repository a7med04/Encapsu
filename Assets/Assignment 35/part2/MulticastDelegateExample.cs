using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class MulticastDelegateExample : MonoBehaviour
    {
        delegate void MathOperation(int number);
        void Start()
        {
            MathOperation operation;
            void DoubleNumber(int number) => Debug.Log($"The Double of {number} is {number * 2}");
            void SquareNumber(int number) => Debug.Log($"The Square of {number} is {number * number}");
            void CubeNumber(int number) => Debug.Log($"The Cube of {number} is {number * number * number}");  
            operation = DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;
            operation(5);
        }
    }
}