using UnityEngine;

public class TryCatchDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int[] arr = new int[2];
            arr[100] = 10; //OutOfRangeException
        }
        catch
        {
            Debug.Log("에러가 발생했습니다.");
        }
       
    }
}
/*
예외처리(Exception Handling) :try-catch-finally 문을 사용
에외(오류)
- 문법 오류
- 런타임 오류(실행중 나오는 오류(버그))
- 알고리즘 오류(알고리즘을 잘 못짰을때 생기는 오류)
 
구문
try
   {
        //명령문
        //.....
   }
   catch
   {
        //try코드블록 안에 있는 명령문들을 실행중 에외(Exception) 발생시 처리할 내용
        //...
   }

 */
