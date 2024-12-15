using UnityEngine;
namespace Lecture18
{
    public class AdvancedFunction1 : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(AddNumbers(1, 2));
            Debug.Log(AddNumbers(new int[] { 1, 2, 3, 4 }));
            Debug.Log(AddNumbers1(1, 2, 3, 4 ));


        }

        public int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public int AddNumbers(int[] numbers)
        {
            int total = 0;
            foreach(int num in numbers){
                total += num;
            }
            return total;
        }
        public int AddNumbers1(params int[] numbers)
        {
            int total = 0;
            foreach(int num in numbers){
                total += num;
            }
            return total;
        }

    }
}