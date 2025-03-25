using UnityEngine;

namespace Exer
{
    public class ClassB : MonoBehaviour
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }

        void Start()
        {

            int result = Add(5, 6);
            Debug.Log("결과: " + result);
        }

    }
}