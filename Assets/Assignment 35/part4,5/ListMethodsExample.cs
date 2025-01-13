using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
        List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6};
        void Start()
        {
            numbers.Sort();
            numbers.Sort((x, y) => y.CompareTo(x));
            print(string.Join(", ",numbers));

            List<int> filteredNumbers = numbers2.FindAll( a => a % 2 == 0 );
            print(string.Join(", ",filteredNumbers));
        }
    }
}