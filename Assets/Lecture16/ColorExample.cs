using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture16
{

    public class ColorExample : MonoBehaviour
    {
        public Color color;

        public Color startColor = Color.red;
        public Color endColor = Color.blue;
        Renderer renderer ;
        Material material ;
        float timer = 0;
        public float speed = 10;
        void Start()
        {
            renderer = GetComponent<Renderer>();
            material = renderer.material;
            //material.color = new Color(Random.Range(0 , 1.000001f), Random.Range(0 , 1.000001f),Random.Range(0 , 1.000001f));
            //material.color = new Color(Random.value, Random.value, Random.value); // return between 1,0
        }

        void Update()
        {
            timer += Time.deltaTime;
            material.color = Color.Lerp(startColor, endColor, timer / speed  );



        }
    }
}