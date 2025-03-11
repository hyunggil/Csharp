using UnityEngine;

public class FunctionPrectice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result;
        result = Add(5, 3);
        Debug.Log(result);
        result = Substact(5, 3);
        Debug.Log(result);
        result = Multiply(5, 3);
        Debug.Log(result);
        result = Devide(5, 3);
        Debug.Log(result);
        result = Reminder(5, 3);
        Debug.Log(result);

    }
    int Add(int x, int y)
    {
        return x + y;
    }
    int Substact(int x, int y) => x - y;
    int Multiply(int x, int y) => x * y;
    int Devide(int x, int y) => x / y;
    int Reminder(int x, int y) => x % y;
}
/*
-사칙 연산을 구하는 함수 만들기

두개의 정수를 입력받아 +,-,*,/,% 계산하며
결과값을 반환하는 함수 만들기
입력값: 5,3
[output]
 */