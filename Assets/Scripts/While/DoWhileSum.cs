using UnityEngine;
//dowhile문을 이용해서 1부터 1(100)까지의 정수 중에서 짝수의 합을 구하는 프로그램 구현
public class DoWhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        int n = 100;
        int sum = 0;
        //초기식
        int i = 1;
        do
        {
            //반복실행문
            if (i % 2 == 0)
            {
                sum = sum + 1;
            }
            i++;    //증감식
        } while (i <= n);   //조건식
        Debug.Log($"1부터 {n}까지의 정수 중에서 짝수의 합을 구하면 {sum}이다.");
    }
}
