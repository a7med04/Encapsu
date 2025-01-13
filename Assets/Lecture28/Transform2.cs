using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture28
{
    public class Transform2 : MonoBehaviour
    {
        void Start()
        {
            // Child (1)
            // GameObject gameObject = GameObject.Find("Child (1)");
            // Debug.Log(gameObject.name);
            // Debug.Log(gameObject.transform.parent);
            // Debug.Log(gameObject.transform.parent.parent);
            // Debug.Log(gameObject.transform.root); // بجيب جد الجد

            // GameObject gameObject = GameObject.Find("God Father");
            // Debug.Log(gameObject.transform.GetChild(0)); //  يعني الابن الاول
            // Debug.Log(gameObject.transform.GetChild(2)); //  يعني الابن الثالث
            // Debug.Log(gameObject.transform.GetChild(3)); //  يعني الابن الرابع
            // for (int i = 0; i < gameObject.transform.childCount; i++){
            //     Debug.Log(gameObject.transform.GetChild(i).name);
            // }
            // foreach (Transform child in gameObject.transform){
            //     Debug.Log(child.name);
            // }

            GameObject munshaq = GameObject.Find("Khamis");
            munshaq.transform.SetParent(GameObject.Find("AL Bandora").transform);

        }
    }
}