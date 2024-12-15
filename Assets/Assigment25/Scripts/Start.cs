using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assigment25
{
    public class Start1 : MonoBehaviour
    {
        public Transform clown;
        public Transform box;
        public float openAngle = 90f;
        public float speed = 2f;
        public Vector3 scaleFactor = new Vector3(3f, 3f, 3f) ;
        private float timer = 0.0f;
        void Start()
        {
            clown.localScale = Vector3.zero;
            box.localRotation = Quaternion.Euler(0, 0, 0);
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow)){
                timer += Time.deltaTime;

                float angle = Mathf.Lerp(0, openAngle, timer / speed);
                box.localRotation = Quaternion.Euler(-angle, 0, 0);

                clown.localScale = Vector3.Lerp(Vector3.zero, scaleFactor, timer / speed);
            }
            if (Input.GetKey(KeyCode.RightArrow)){
                timer -= Time.deltaTime;

                float angle = Mathf.Lerp(0, openAngle, timer / speed);
                box.localRotation = Quaternion.Euler(-angle, 0, 0);

                clown.localScale = Vector3.Lerp(Vector3.zero, scaleFactor, timer / speed);
            }        
        }
    }
}