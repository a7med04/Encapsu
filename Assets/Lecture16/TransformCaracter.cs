using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture16
{
    public class TransformCaracter : MonoBehaviour
    {
        public GameObject gameObjectt;
        //public float speed = 90f;
        void Start()
        {

        }

        void Update()
        {
            // transform.Rotate(Vector3.up, speed  * Time.deltaTime);
            // transform.Translate(new Vector3(1 * Time.deltaTime, 0, 0));
            transform.LookAt(gameObjectt.transform);

            if (Vector3.Distance(gameObjectt.transform.position, transform.position) > 0.1)
            {
                transform.Translate(Vector3.forward * Time.deltaTime, Space.Self);
            }

        }
    }
}