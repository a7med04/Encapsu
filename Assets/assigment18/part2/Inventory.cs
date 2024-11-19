using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18.part2
{
    public class Inventory
    {
        private List<string> store = new List<string>();
      
        public void AddItem(string item){
                store.Add(item);
        }

        public void ShowItems(){
            for(int i = 0; i < store.Count; i++){
                Debug.Log(store[i]);
            }
        }

       
    }
}