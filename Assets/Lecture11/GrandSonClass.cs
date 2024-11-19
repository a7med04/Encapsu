using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture11
{

    public class GrandSonClass : ChildClass
    {
        public override void PrintInfo()
        {
            Debug.Log("222222");
            base.PrintInfo();
            Debug.Log("I am The Grand Son Class ");
        }
    }

}