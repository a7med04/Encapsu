using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture13
{
    public class InputLesson : MonoBehaviour
    {
        void Start()
        {
            // Debug.Log(Mathf.PI);
            // Debug.Log(Mathf.Exp(1));
            // Debug.Log(Mathf.Abs(-20));
            // Debug.Log(Mathf.Min(1,5,7));
            // Debug.Log(Mathf.Max(1,5,7));
            // Debug.Log(Mathf.Clamp(101,0,100)); // الناتج 100
            // Debug.Log(Mathf.Clamp(-1,0,100)); // الناتج 0
            // // مثال على ما سبق  health = Mathf.Clamp(value, 0, 100);
             
            // Mathf.Round(1.6f);//  =~ 2 
            // Mathf.Round(1.2f);//  =~ 1 

            // Mathf.Floor(4.5f); // =~ 4
            // Mathf.Ceil(4.5f); // =~ 5

            // Mathf.Lerp(0, 10, 0.5f); // = 5 

            // Mathf.Sin(0);
            // Mathf.Tan(0);
            // Mathf.Cos(0);

            // Mathf.Sqrt(25);
            // Mathf.Pow(2,2);

            // Mathf.PingPong();
        }
        void Update()
        {
            // if (Input.GetMouseButtonUp(0)){ // left button
            //     Debug.Log("Mouse Left !");
            // }
            // if (Input.GetMouseButtonUp(1)){ // Right button
            //     Debug.Log("Mouse Right  !");
            // }
            // if (Input.GetMouseButtonUp(2)){ // Middle button
            //     Debug.Log("Mouse Middle !");
            // }
            // if (Input.mouseScrollDelta.y != 0){ // Mouse Wheel Scrolling
            //     Debug.Log("Mouse Scrolling Occured : " + Input.mouseScrollDelta.y); 
            // }

            // Vector3 v1 = new Vector3(0, 0, 0); //   Immutable Values غير قابلة للتعديل
            // Vector3 v2 = new Vector3(1, 0, 0);
            // Vector3 v3 = v1 + v2; // = (1,0,0) 
            // Vector3 v4 = v1 * 5;

            // Vector3 beginVector = new Vector3(5, 5, 0);
            // Vector3 endVector = new Vector3(10, 5, 0);
            // Debug.Log(Vector3.Lerp(beginVector, endVector, .5f));

            // Time Class
            //Debug.Log(Time.time); //play بداية تايمر ويبدا العد عند الضغط على 
            //Debug.Log(Time.frameCount); //play عدد الفريمات  من بداية الضغط على زر
            //Debug.Log(Time.deltaTime); // الفرق في الوقت بين كل فريم واخر
            // Debug.Log(Time.fixedDeltaTime); 

            Time.timeScale = 0f; // default = 1 / سرعة الوقت سواء مضاعفة او نقصان / timeScale = 0 ==> pause
            Debug.Log(Time.unscaledTime); 
            //حتتاثر وتساو  0 Time.time ال timeScale = 0 لما يكون ال
            //play مش حتتاثر وحتشغل الكاونتر عادي لما تضغط على زر  Time.unscaledTime لكن ال
        }
    }
}