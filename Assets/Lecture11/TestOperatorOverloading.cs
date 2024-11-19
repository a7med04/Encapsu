using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture11
{
    public class TestOperatorOverloading : MonoBehaviour
    {
        void Start()
        {
            OperatorOverloading a = new OperatorOverloading(5);
            OperatorOverloading b = new OperatorOverloading(10);

            Debug.Log(a + b);
            Debug.Log(a + 20);
        }

    }
}