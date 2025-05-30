using UnityEngine;
using System.Collections;

public class StackNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] stack 클래스의 인스턴트 (객체, 개체)생성
        Stack stack = new Stack();

        //[2]push로 데이터 저장
        stack.Push("대한민국");
        stack.Push("서울특별시");
        stack.Push("강동구");

        //[3]스택의 제일 상단(마지막)의 데이터를 반환
        Debug.Log($"{stack.Peek()}, {stack.Count}");
        //[4] Pop() 스택에서 데이터 꺼내기
        stack.Pop();
        //[5]
        Debug.Log($"{stack.Peek()}, {stack.Count}");
        //[6]
        if (stack.Count > 0)
        {
            stack.Pop();
        }
        //[7]
        stack.Clear();
        Debug.Log($"{stack.Count}");
    }
}
