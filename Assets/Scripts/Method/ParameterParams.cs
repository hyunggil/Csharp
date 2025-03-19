using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

namespace Method
{
    //[4] 가변형 전달방법 (params int[] numbers)
    //params : 가변 길이 매개 변수
    public class ParameterParams : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(SumAll(3, 5));
            Debug.Log(SumAll(3, 5, 7));
            Debug.Log(SumAll(3, 5, 7, 9));
        }
        //매개변수로 입력 받은 정수들의 합을 구하는 메서드
        int SumAll(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            return sum;
        }
        
    }
}