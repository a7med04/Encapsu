using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class MethodChainingExample : MonoBehaviour
    {
        class Chaining 
        {
            Transform transform;

            public Chaining(Transform transform) => this.transform = transform;

            public Chaining SetPosition(Vector3 position){
                transform.position = position;
                return this;
            }

            public Chaining SetRotation(Vector3 rotation){
                transform.rotation = Quaternion.Euler(rotation);
                return this;
            }

            public Chaining SetScale(Vector3 scale){
                transform.localScale = scale;
                return this;
            }
        }
        void Start()
        {
            Chaining a7 = new Chaining(transform);
            a7.SetPosition(new Vector3(0, 1, 0)).SetRotation(new Vector3(45, 0, 0)).SetScale(new Vector3(2, 2, 2));
        }    
    }
}