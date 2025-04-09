using UnityEngine;

namespace Problem
{
    public class MinNumber : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //숫자 배열 선언
            int[] numbers = { -2, -5, -3, -7, -1 };
            //배열의 최소값을 찾기
            int minValue = FindMinValues(numbers);
            //최소값 출력
            Debug.Log($"배열의 최소값은: {minValue}");

        }
        //최소값을 찾는 메서드
        int FindMinValues(int[] numbers)
        {
            //첫번째 값을 최소값으로 지정
            int min = numbers[0];
            //배열의 각 원소를 하나씩 비교
            foreach (var num in numbers)
            {
                //만약 현재값이 최소값보다 작으면
                if(num < min)
                {
                    //최소값을 num으로 갱신
                    min = num;
                }
            }
            //최소값을 반환하라
            return min;
        }
    }
}