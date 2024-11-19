using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture11
{
    public class MethodGenerics 
    {   
        // public static int AddNum(int a, int b){
        //     return a + b;
        // }
        // public static double AddNum(int a, double b){
        //     return a + b;
        // }
        // public static double AddNum( double b, int a){
        //     return a + b;
        // }

        public static void PtintNum<T>(T a){  // DataType كانها  T اصبحت ال 
            Debug.Log(a);
        }
 



    }
}