using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
namespace Assignment37
{
    public class RigidBodyCharacterController : MonoBehaviour
    {
        Rigidbody rigid;
        float speed = 5;
        Vector3 @in;
        bool jump = false;  
        void Start()
        {
            rigid = GetComponent<Rigidbody>();
            rigid.mass = 5;
            rigid.freezeRotation = true;
        }

        void Update()
        {
            @in = new Vector3(Input.GetAxisRaw("Horizontal"),
                                0,
                                Input.GetAxisRaw("Vertical"));
            @in = @in.normalized * speed;
            @in.y = rigid.velocity.y;
            
            if (Input.GetKeyUp(KeyCode.Space)){
                jump = true;
            }
        }

        void FixedUpdate()
        {
            if(jump)
            {
                rigid.drag = 0.5f;
                rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
                jump = false;
            }
            else
            {
                rigid.drag = 0f;
                rigid.velocity = @in;
            }
        }
    }
}