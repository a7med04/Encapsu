using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture12
{
    public class UnderstandingMonoBehaviourScript : MonoBehaviour
    {
       // int co = 0;
        void Start() // عند بداية اول فريم
        {
            // Vector3 pos = new Vector3(1f,1f,1f);
            // Vector3 rot = new Vector3(45,0,0);
            // Vector3 scal = new Vector3(2,1,1);
            // Debug.Log(pos);
            // Debug.Log(rot);
            // Debug.Log(scal);


            // Debug.Log(Vector3.zero);
            // Debug.Log(Vector3.one);

            // Debug.Log(Vector3.up);      //  (0,1,0)
            // Debug.Log(Vector3.down);    //  (0,-1,0)
            // Debug.Log(Vector3.right);   //  (1,0,0)
            // Debug.Log(Vector3.left);    //  (-1,0,0)
            // Debug.Log(Vector3.forward); //  (0,0,1)
            // Debug.Log(Vector3.back);    //  (0,0,-1)
        }

        void Update() // تنادى عند بداية الفريم
        {
            // if (Input.GetKeyUp(KeyCode.Space)){
            //         Debug.Log("Space Up");
            // }
            // if (Input.GetKey(KeyCode.Space)){
            //         Debug.Log("Space Pressed");
            // }
            // if (Input.GetKeyDown(KeyCode.Space)){
            //         Debug.Log("Space Down");
            // }

            // float axis = Input.GetAxis("Horizontal"); // -1 to 0 to 1 هادي بتجيب بكسور عشان يزبط الفريمات
            // float axis = Input.GetAxisRaw("Horizontal"); // -1 to 0 to 1 هادي بتجيب بدون كسور
            float axis = Input.GetAxis("Vertical");
            
            Debug.Log(axis);

           // Debug.Log(Input.mousePosition); //vector3 بعطيني موقع الماوس ك 



            //Debug.Log(co++);
        }







        // void Awake(){ //play عند الضغط على 

        // }
        // void lateUpdate() // تنادى عند نهاثية الفريم
        // {

        // }
        // void FixedUpdate() // بناديها عند كل وقت زمني محدد بغض النظر عن عدد الفريمات نقريبا كل 0.02 ثانية
        // {

        // }
        // void OnEnable(){ // play لما بشغل السكربت بظهر + ولما اعمل 
            
        // }
        // void OnDisable(){ // لما بطفي السكربت بظهر

        // }

    }
}