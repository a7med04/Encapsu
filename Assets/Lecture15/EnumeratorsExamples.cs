using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture15
{
    public class EnumeratorsExamples : MonoBehaviour
    {
        void Start()
        {
            // int character = 0; // 0 - Stopping || 1 - walking || 2- Running || 3 - Jumping
            // character = 1;
            // if (character == 1){
            //     Debug.Log("Character Is Walking");
            // }

            CharacterState character2 = CharacterState.Jumping;

            // if (character2 == CharacterState.Stopping){
            //     Debug.Log("Character2 Is Stopping");
            // }
            // else if (character2 == CharacterState.Walking){
            //     Debug.Log("Character2 Is Walking");
            // }
            // else if (character2 == CharacterState.Running){
            //     Debug.Log("Character2 Is Running");
            // }
            // else if (character2 == CharacterState.Jumping){
            //     Debug.Log("Character2 Is Jumping");
            // }
            // else if (character2 == CharacterState.Shooting){
            //     Debug.Log("Character2 Is Shooting");
            // }
            // else {
            //     Debug.Log("Any Other State ...");
            // }
           


            switch (character2){
                case CharacterState.Stopping:
                    Debug.Log("Character2 Is Stopping");

                    break;

                case CharacterState.Walking:
                    Debug.Log("Character2 Is Walking");

                    break;

                case CharacterState.Running:
                    Debug.Log("Character2 Is Running");

                    break;

                case CharacterState.Jumping:
                    Debug.Log("Character2 Is Jumping");

                    break;

                case CharacterState.Shooting:
                    Debug.Log("Character2 Is Shooting");

                    break;

                default:
                    Debug.Log("Any Other State ...");

                    break;


                
            }

        }
    }
}