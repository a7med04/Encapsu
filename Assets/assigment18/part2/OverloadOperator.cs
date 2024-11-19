using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment18.part2
{
    public struct OverloadOperator 
    {
        public string invent;
        public OverloadOperator(string invent){
            this.invent = invent;
        }

        public static string operator +(OverloadOperator a,OverloadOperator b){
            return a.invent + b.invent;
        }
    }
}
