using UnityEngine;
//안녕하세요를 3번 출력하는 프로그램
public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //초기식
        int i = 0;
        do
        {
            //반복 실행문
            Debug.Log("안녕하세요.");
            i++;
        } while (i < 3);    //조건식
    //i:0 ->출력 -> i:1 -> i<3 참 -> 출력 -> i:2 -> i<3 ->참 ->출력 ->i:3->i<3->거짓 ->dowhile문 종료
    }
}
/*
dowhile문 - 반복문
먼저 반복 실행문을 1번 실행한다.
조건식이 true이면 반복문을 실행한다
조건식이 false면 while문을 종료한다.

do
{
    //반복 실행문
}
while(조건식)
 */