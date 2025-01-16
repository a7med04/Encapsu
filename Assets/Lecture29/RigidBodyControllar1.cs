using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture29
{
    public class RigidBodyControllar1 : MonoBehaviour
    {
        Rigidbody rigbody;
        Vector3 input;
        float batahSpeed = 5;
        bool jump = false;
        void Start()
        {
            rigbody = GetComponent<Rigidbody>();
            // Debug.Log((new Vector3(4, 0, 0).magnitude));
            // Debug.Log((new Vector3(4, 0, 4).magnitude));
            // Debug.Log((new Vector3(4, 0, 4).normalized).magnitude);
            
            
            // rigbody.mass = 10;
            // rigbody.drag = 0.1f; // مقاومة
            // rigbody.angularDrag = 0.06f; // مقاومة دائرية
            // rigbody.useGravity = true; // التعرض للجاذبية
            // rigbody.isKinematic = true; 
            rigbody.freezeRotation = true;
            // rigbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        }

        void Update()
        {
            // Input.GetAxis("Horizontal"); // -> float ---> A = -1, B = 1
            // Input.GetAxis("Vertical"); // -> float ---> W = 1, S = -1
            input = new Vector3(Input.GetAxisRaw("Horizontal"), 
                                0, 
                                Input.GetAxisRaw("Vertical"));
            input = input.normalized * batahSpeed; // حتى يحافظ على السرعة تكون ثابتة في كل الحاالات
            input.y = rigbody.velocity.y;
            // Debug.Log(input.magnitude);

            if(Input.GetKeyUp(KeyCode.Space)){
                jump = true;
            }
        }

        void FixedUpdate() // كل ما يتعلق بالفيزياء يوضع هنا // الفريمات ثابتة هنا (بين كل فريم وفريم الزمن ثابت )
        {
            // rigbody.velocity = new Vector3(4, rigbody.velocity.y, 0);
            // rigbody.rotation = Quaternion.Euler(0, 90, 0);

            if (jump){
                rigbody.drag = 0.5f;
                rigbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
                jump = false;
            }
            else 
                rigbody.drag = 0.5f;
                rigbody.velocity = input;
        }
    }
}