using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math2 
{
    public static int Muliyply(int n1, int n2){
        return n1 * n2;
    }

    public static string Muliyply(string name, int n){
        string result = " ";
        for(int i = 0; i < n; i++){
            result += name + " ";
        }
        return result;
    }

    public static string Muliyply(int n, string name){
        return Muliyply(name, n);
    }

}
