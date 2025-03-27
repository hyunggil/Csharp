using UnityEngine;

namespace Problem
{
    public class ClassB : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ClassA의 인스턴스 선언
            ClassA classA = new ClassA();
            //ClassA 출력
            classA.PrintDay();
            //합계 결과 출력
            int result = ClassA.Sum(5, 6);
            {
                Debug.Log($"결과: {result}");
            }
        }

    }
}