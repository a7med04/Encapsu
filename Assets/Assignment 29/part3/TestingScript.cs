using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment29
{
    public class TestingScript : MonoBehaviour
    {
        void Start()
        {
            print(Utilities.Add(4, 5, 6, 1, 8, 7, 4));

            string word = "Unity";
            print(word.RepeatString(3));
        }
    }
}