using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        public GameObject TargetObject;
        public GameObject Joker;
        public Light Light;
        void OnEnable(){
            print("GameObject Enabled");
        }
        void Start()
        {
            print("Game started!");
            
            TargetObject = GameObject.Find("TargetObject");
            if (TargetObject != null)
            {
                print("Found object by name: " + TargetObject.name);
            }

            else{
                print("No TargetObject found.");
            }


            Joker = GameObject.Find("Joker");
            if (Joker != null)
            {
                print("Found object by tag: " + Joker.name);
            }

            else{
                print("No Joker object found.");
            }


            Light = GameObject.FindObjectOfType<Light>();
            if (Light != null)
            {
                print("Found object of type Light: " + Light.name);
            }

            else{
                print("No Light object found.");
            }
        }
        void Update(){
            if (Input.GetKeyUp(KeyCode.D)){
                TargetObject.SetActive(true);
                print("TargetObject deactivated!");
            }
        }
        void OnDisable(){
            print("GameObject Disabled");
        }
    }
}