using UnityEngine;
namespace Exer
{
    public class MinValue : MonoBehaviour
    {


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // 배열 초기화
            int[] numbers = { -2, -5, -3, -7, -1 };

            // 최소값을 구하는 함수 호출
            int minValue = FindMinValue(numbers);

            // 결과 출력
            Debug.Log("최소값: " + minValue); 
        }

        
        int FindMinValue(int[] values)
        {
            int min = values[0]; 

            
            for (int i = 1; i < values.Length; i++)  
            {
                if (values[i] < min)
                {
                    min = values[i]; 
                }
            }

            return min; 
        }
    }
}
