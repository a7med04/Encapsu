using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment29
{
    public class CustomObject 
    {
        private int id;
        private string name;

        public int Id{
            private set{}
            get { return id; }    
        }    
        
        public string Name{
            private set{}
            get { return name; } 
        }  

        public CustomObject(int id, string name){
            this.id = id;
            this.name = name;
        }

        public override string ToString(){
            return ($"Object [ID: {id}, Name: {name}]");
        }


        // if ((c1.name).Equals(c2.name))
        //     {
        //         Debug.Log("The Same CustomObject");
        //     }

        public static bool operator ==(CustomObject c1, CustomObject c2)
            {
                if (!c1.Equals(null) && !c2.Equals(null))
                {
                    if (c1.name.Equals(c2.name)) return true;
                }
                return false;
            }

            public static bool operator !=(CustomObject c1, CustomObject c2)
            {
                if (!c1.Equals(null) && !c2.Equals(null))
                {
                    if (!c1.name.Equals(c2.name)) return true;
                }
                return false;
            }
    }
}