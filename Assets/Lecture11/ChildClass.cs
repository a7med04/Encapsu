using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture11
{
    public class ChildClass : BaseClass
    {
        public override void PrintInfo()
        {
            Debug.Log("111111");
            base.PrintInfo();
            Debug.Log("I am The Child Class ");
        }

    }

}