using System.Collections;   //collection을 선언할때 쓴다.
using UnityEngine;

//Collections : Stack , Queue, ArrayList, HashTable
public class StatClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //stack 클래스의 인스턴스(객체) 생성
        Stack st = new Stack();

        //스택에 데이터 넣기: push
        st.Push("First");
        st.Push("Second");
        st.Push("third");

        //스택에서 데이터 꺼내기: Pop
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());


    }
}
