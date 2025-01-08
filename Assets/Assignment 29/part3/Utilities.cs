using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment29
{
    public static class Utilities 
    {
        public static int Add(params int[] numbers){
            int sum = 0;
            foreach (var num in numbers){
                sum += num;
            }
            return sum;
        }

        public static string RepeatString(this string word, int repeates){

            string result = "";
            for(int i = 1; i <= repeates; i++){
                result += word;
            }
            return result;
        }
    }
}
