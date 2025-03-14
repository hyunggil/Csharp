using UnityEngine;
using System.Collections.Generic;
using System.Linq;
//LinqWhere(where절, 조건절)
public class LinqWhere : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수형 배열 numbers 의 요소수 (3보다 크고 짝수)인 수들 구하기
        int[] numbers = { 1, 2, 3, 4, 5 };
        
        //IEnumerable<int> nunumbers.Where(n => n > 3);
        List<int> nunumbers = numbers.Where(n =>n > 3 && n %2 == 0).ToList();
        
        foreach (var n in nunumbers)
        {
            Debug.Log(n);
        }
        
    }
}
