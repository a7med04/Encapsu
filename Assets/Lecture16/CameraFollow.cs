using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture16
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;
        private Vector3 difference;
        public bool lookAt = true;
        void Start()
        {
            difference = transform.position - target.position;
        }

        void LateUpdate()
        {
            
            Vector3 newPosition = Vector3.Lerp(transform.position, target.position + difference, 0.02f);
            transform.position = newPosition ;
            if (lookAt){
                transform.LookAt(target);
            }
        }
    }
}
