using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture16
{
    public class MoveObject : MonoBehaviour
    {
        float speed = 5f;
        void Start()
        {
            Camera.main.backgroundColor = Color.red;

        }

        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = 10;
                Vector3 inUnityPosition = Camera.main.ScreenToWorldPoint(mousePosition);
                //transform.position = inUnityPosition;
                transform.position = Vector3.Lerp(transform.position, inUnityPosition, speed * Time.deltaTime);
            }
            //Debug.Log(mousePosition);
        }
    }
}
