using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        void Start()
        {
            print(FibonacciRecursive(10));
            print(FibonacciRecursive(30));
        }

        public int FibonacciRecursive(int n){
            if (n < 0) return -1;
            if (n == 0) return 0;
            if (n == 1) return 1;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}
