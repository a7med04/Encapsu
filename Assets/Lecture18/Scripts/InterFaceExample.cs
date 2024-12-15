using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture18
{
    public interface InterFaceExample 
    {
        // public void DoAnything(){
        //     Debug.Log("Ahmed");
        // }
        public void DoAnything();
        public int Health{
            get;
            set;
        }
    }

    public class BintInterFaceExample : InterFaceExample
    {
        public void DoAnything(){
            Debug.Log("Ahmed");
        }
        private int _health = 100;
        public int Health{
            get{ return _health; }
            set{ _health = Mathf.Clamp(value, 0, 100); }
        }
    }
}