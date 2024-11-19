using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
            GameContainer<string> containar = new GameContainer<string>();
            containar.SetItem("Healing Potion");
            containar.GetItem();

            GameUtils.DescribeItem("Healing Potion");
            
 
        }

    }
}