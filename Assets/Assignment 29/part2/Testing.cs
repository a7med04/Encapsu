using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment29
{
    public class Testing : MonoBehaviour
    {
        void Start()
        {
            CustomObject cus1 = new CustomObject(123, "Ahmed");
            print(cus1.ToString());

            CustomObject cus2 = new CustomObject(123, "Ahned");
            if (cus1.Equals(cus1))
            {
                print("The Same Custom");
            }
        }

        
    }
}