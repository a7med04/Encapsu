using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture11
{
    public class TestGenerics : MonoBehaviour
    {
        void Start(){
            // MethodGenerics.AddNum(1, 3.5);
            // MethodGenerics.AddNum(1.5, 4);

            MethodGenerics.PtintNum<int>(4);

            ClassGenerics<int> cg = new ClassGenerics<int>(4);
            cg.PtintV();


        }
    }
}