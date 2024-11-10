using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Encapsulation2 : MonoBehaviour
{
    void Start()
    {
        Player a7 = new Player();
        a7.GetDamage(10);
        Debug.Log(a7.HealthAmount());
        a7.Heal(50);

        // Math m1 = new Math(); // -----> instance هادي الحركة اسمها 
        // Debug.Log(m1.Multiply(5, 4));
        Debug.Log(Math.Multiply(5, 4)); // Static ----> instance تستخدم للتعامل مع الكلاس مباشرة بدون ان اعمل  
        //Debug.Log(Math.name); // اذا تم استخدامها اي نسخة يعدل عليها يتم التعديل على كل النسخ variables بالنسبة لل  Static ال 
        // Math m1 = new Math();
        // Math m2 = new Math();

        // m1.ChangeName("Ahmed");
        // Debug.Log(m2.GetName());

        Debug.Log(Math2.Muliyply(2, 3));
        Debug.Log(Math2.Muliyply("Ahmed", 3));
        Debug.Log(Math2.Muliyply(2, "A7"));
  
    }

}
