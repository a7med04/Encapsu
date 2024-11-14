using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    public override void MakeSound(){ // override ---> من ميثود اخرى ovverride لانه تم عمل  
        Debug.Log("Meoooow");
    }
}
