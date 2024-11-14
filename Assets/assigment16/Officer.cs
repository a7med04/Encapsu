using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public class Officer : Character
    {
        public Officer() : base("No name", 100, new Position(0,0,0)){
        }

        public void DisplayInfo(){
            Debug.Log("Officer");
            base.DisplayInfo();
        }
    }
}