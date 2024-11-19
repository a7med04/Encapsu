using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
namespace Lecture11
{
    public class ClassGenerics<T>
    {
        public T v;

        public ClassGenerics(T v){
            this.v = v;
        }

        public void PtintV(){
            Debug.Log(v);
        }        
    }
}