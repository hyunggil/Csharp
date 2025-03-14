using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
public class AveragePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<int> data = new List<int>() { 90, 65, 78, 50, 95 };
        List<int> num = data.Where(n => n >= 70 && n <= 95).ToList();
        double average = num.Average();
        Debug.Log($"평균점수: {average: 0.00}");
    }
}
/*
[Q]
입력 데이터{90,65,78,50,95}
국어점수 중 70점 이상이고 95점 이하인 점수들의 평균을 구해 보아라.

[output]-소수점이하 2자리까지
평균점수: average
 */