using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture11
{
    public class TestBaseClass : MonoBehaviour
    {
        void Start()
        {
            BaseClass bass = new BaseClass();
            ChildClass child = new ChildClass();
            GrandSonClass grandSon = new GrandSonClass();

            bass.PrintInfo();
            child.PrintInfo();
            grandSon.PrintInfo();
            

        }

    }
}