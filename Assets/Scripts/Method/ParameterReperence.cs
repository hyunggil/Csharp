using UnityEngine;

namespace Method
{
    //참조 전달 방법 (ref int new)
    public class ParameterReperence : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int number = 10;
            Debug.Log($"[1] {number}");

            PrintNumber(ref number);

            Debug.Log($"[3] {number}");
        }
        //정수형 ref number를 매개 변수로 입력받아 출력하는 함수
        void PrintNumber(ref int number)
        {
            number = 20;
            Debug.Log($"[2] {number}");
        }
    }
}