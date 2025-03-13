using UnityEngine;
using System.Collections;

public class StackNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] stack Ŭ������ �ν���Ʈ (��ü, ��ü)����
        Stack stack = new Stack();

        //[2]push�� ������ ����
        stack.Push("���ѹα�");
        stack.Push("����Ư����");
        stack.Push("������");

        //[3]������ ���� ���(������)�� �����͸� ��ȯ
        Debug.Log($"{stack.Peek()}, {stack.Count}");
        //[4] Pop() ���ÿ��� ������ ������
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
