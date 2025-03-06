using UnityEngine;

public class ForSumPrectice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;
        for(int i = 1; i < 101; i = i+3)
        {
            sum = sum + i;
        }
        Debug.Log($"답은 {sum}");
        int sum1 = 0;
        for(int j = 1; j < 101; j = j+4)
        {
            sum1 = sum + j;
        }
        Debug.Log($"답은{sum + sum1}");
    }

}
/*
1부터 100가지 정수 중에서 3의 배수 또는 4의 배수를 구해서 합하는 프로그램 구현
 */