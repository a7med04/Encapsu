using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        void Start()
        {
            int health = 100;
            object obj = health;
            int ret = (int)obj;
            ret = 50;

            Debug.Log($"The original value : {health}");
            Debug.Log($"The boxed value : {obj}");
            Debug.Log($"The unboxed value : {ret}");
        }
    }
}