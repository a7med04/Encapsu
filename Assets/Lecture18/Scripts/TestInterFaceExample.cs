using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture18
{

    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            BintInterFaceExample bie = new BintInterFaceExample();
            bie.DoAnything();

        }

        
    }
}