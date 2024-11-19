using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18.part1
{
    public class GameContainer <T> 
    {
        public T item;

        public void SetItem(T item){
            this.item = item;
        }
        public void GetItem(){
            Debug.Log("Stored item : " + item);
        }
    }
}