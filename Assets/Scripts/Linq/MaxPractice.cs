using UnityEngine;
using System.Collections.Generic;
using System.Linq;
public class MaxPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<int> num = new List<int>() { -2, -5, -3, -7, -1 };
        //최대값을 저장하는 변수
        //max의 초기화 값: max의 데이터 타입이 가지는 값 중 가장 작은값

        int max = int.MinValue;
        max = num.Max();

        Debug.Log($"최대값은: {max}");

        /*
        int max = int.MinValue;

        for(int i = 0 ; i < num.Length; i++)
        {
            if(num[i] > max)
                {
                    max = num[i];
                {
        }
        Debug.Log($"최대값은 {max})");

         */
    }
}
/*
[Q]
입력데이터 {-2,-5,-3,-7,-1}

[output]
최댓값 -1
 */
