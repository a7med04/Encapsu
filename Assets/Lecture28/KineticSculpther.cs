using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
namespace Lecture28
{
    public class KineticSculpther : MonoBehaviour
    {
        float angle = 45;
        float delayTime = 0;
        void Start()
        {
            Transform parent = GameObject.Find("Boxes").transform;
            foreach (Transform child in parent){
                StartCoroutine(RotateSomething(child, delayTime));
                delayTime += 0.03f;
            }

        }

        void Update()
        {

        }

        IEnumerator RotateSomething(Transform something, float delay)
        {
            float startTime = Time.time + delay;
            //float elepsedTime = 0; // الوقن الذي استغرق
            while (true)
            {
                //elepsedTime = Time.time - startTime;
                something.rotation = Quaternion.Euler(0, Mathf.Sin((Time.time - startTime) * 6) * angle, 0);
                yield return null;
            }
        }
    }
}