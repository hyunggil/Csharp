using System.Collections;   //collection�� �����Ҷ� ����.
using UnityEngine;

//Collections : Stack , Queue, ArrayList, HashTable
public class StatClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //stack Ŭ������ �ν��Ͻ�(��ü) ����
        Stack st = new Stack();

        //���ÿ� ������ �ֱ�: push
        st.Push("First");
        st.Push("Second");
        st.Push("third");

        //���ÿ��� ������ ������: Pop
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());


    }
}
