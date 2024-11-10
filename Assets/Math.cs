using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math 
{
    static public int Multiply(int n1, int n2){
        return n1 * n2;
    }

    static public string name = "A7";

    public void ChangeName(string newName){
        name = newName;
    }

    public string GetName(){
        return name;
    }

}
