using UnityEngine;
//재귀 함수 : 하무가 자신의 코드 블록 안에서 자신을 다시 호출(재귀 호출) 하는 함수
//-재귀함수 매개변수: 매개변수는 감산, 가산이 된다.
//-재귀 함수 코드 블록 안에는 재귀 함수를 종료 할 수있는 조건이 필요하다.
//팩토리얼 구하는 알고리즘(4!)



public class RecusionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //4! = 1*2*3*4
        Debug.Log(4 * 3 * 2 * 1);
        //for factorial
        Debug.Log(Factorial(4));
        
    }
    //for문을 이용 factorial값 구하기
    /*int Factorialfor(int n)
    {
        int result = 1;
        for(int i = 1; i <=n; i++)
        {
            result = result * i;
        }
        return result;
    }*/
    //3항 연산자를 이용한 Factorial 만들기
    int factor(int n)
    {
        return (n > 1) ? n * factor(n - 1) : 1;
    }
    int Factorial(int n)
    {
        //종료 조건 부분
        if(n == 1 || n == 0)
        {
            return 1;
        }
        //재귀 호출 부분
        return n * Factorial(n - 1);
    }

}
//재귀 함수를 이용 factorial값 구하기
