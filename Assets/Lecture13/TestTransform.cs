using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture13
{
    public class TestTransform : MonoBehaviour
    {
        public float x = 0.01f;
        public float deg = 0f;
        public float degInc = 1f;
        
        public Vector3 scaleFactor = new Vector3(0.1f, 0.1f, 0.1f);
        void Start()
        {

            //transform.position = new Vector3(5, 0, 0);
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.RightArrow)){
                deg += degInc;
            }
            else if (Input.GetKey(KeyCode.LeftArrow)){
                deg -= degInc;
            }

            if (Input.GetKey(KeyCode.KeypadPlus)){
                transform.localScale += scaleFactor;
            }
            else if (Input.GetKey(KeyCode.KeypadMinus)){
                transform.localScale -= scaleFactor;
            }
            //transform.position += new Vector3(x, 0, 0);
            transform.rotation = Quaternion.Euler(new Vector3(0, deg, 0));
            //transform.localScale += scaleFactor;

        }
    }
}