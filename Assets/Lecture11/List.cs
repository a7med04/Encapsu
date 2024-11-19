using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture11
{
    public class List : MonoBehaviour
    {
        int[] arr = { 1, 2, 3 };
        List<int> List1 = new List<int>();
        List<int> List2 = new List<int> { 1, 2, 3, 4 };


        void Start()
        {
            arr[1] = 5;
            arr[3] = 8;
            for (int i = 0; i < arr.Length; i++)
            {
                Debug.Log(arr[i]);
            }

            List1.Add(5);
            for(int i = 0; i <List2.Count; i++){  // يهمني  index هذه تستخدم اذا كان ال
                Debug.Log(List2[i]);
            }

            foreach (int n in List2){ // value لا يهمني ولكن يهمني ال index هذه تستخدم اذا كان ال
                Debug.Log(n); // index بطلعهم رقم رقم لكن بدون
            }

            List1.AddRange(arr); // list الى arr تحويل ال
            int[] fromList = List2.ToArray();  // arr الى list تحويل ال
        }


    }
}