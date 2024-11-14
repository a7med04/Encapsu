using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettersAndSetters : MonoBehaviour
{
    public int a = 123;
    public int s = 254;
    [SerializeField]
    private string password = "123";  

    private string Pass{
        get {
            return password;
        }
        set {                           // public void Password (string value){
            password = value;           // password = value; }
            PasswordChange();
        }
    }
        void Start()
    {
        Pass = "abc";
          Debug.Log(Pass);

        Health = 100;
 Debug.Log(Health);

         Debug.Log(password);
        {
            
        }
        {
            
        }
    }
    public void PasswordChange(){
        Debug.Log("Password Was Changed");
    }

    private int health = 100;
    public int Health {
        get { return health; }
        set{
            if (value > 100){
                health = 100;
            }
            else if (value < 0){
                health = 0;
            }
            else {
                health = value;
            }
        }
    }




}


