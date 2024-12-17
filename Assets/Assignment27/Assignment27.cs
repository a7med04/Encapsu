using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment27
{
    public class Assignment27 : MonoBehaviour
    {
        void Start()
        {
            int a = 2;
            int b = 3 ;
            int c;

            Debug.Log(CallByValue(a));
            Debug.Log(CallByReference(ref b));
            Debug.Log(OutKeyword(out c));
        }

        public int CallByValue(int value){
            value += 10;
            return value;
        }

        public int CallByReference(ref int value){
            value += 10;
            return value;
        }

        public int OutKeyword(out int value){
            value = 20;
            return value;
        }
    }
}