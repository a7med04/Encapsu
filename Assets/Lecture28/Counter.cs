using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture28
{
    public class Counter : MonoBehaviour
    {
        float counter;
        float timer;
        int count;
        bool stopCounter = false;
        void Start()
        {
            Coroutine CorCounter = StartCoroutine(Count());

        }

        void Update(){
            // timer += Time.deltaTime;
            // if (timer >= 1){
            //     counter++;
            //     Debug.Log(counter);
            //     timer = 0;
            // }

            if (Input.GetKeyDown(KeyCode.Space)){
                stopCounter = !stopCounter;
            }

        }   

        IEnumerator Count(){
            while(true){
                yield return new WaitForSeconds(1);
                if (!stopCounter)
                {
                    Debug.Log(++count);
                }
            }
        }
    }
}