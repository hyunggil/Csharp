using UnityEngine;
using System.Collections;
public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Stack Ŭ������ ��ü(�ν��Ͻ�,��ü) ����
        Stack stack = new Stack();

        //[2] ������ �ֱ�
        stack.Push("ù ��°");
        stack.Push("�� ��°");
        stack.Push("�� ��°");

        //[3] ������ ��������
        Debug.Log(stack.Pop()); //? ����°
        Debug.Log(stack.Pop()); //? �ι�°
        Debug.Log(stack.Pop()); //? ù��°
        try
        {


            //����ִ� ���ÿ��� Pop�ض�
            Debug.Log(stack.Pop()); //
        }
        catch(System.Exception ex)
        {
            Debug.Log($"��������:{ex.Message}");
        }
    }
}
/*
Stack Ŭ����: LIFO (Last In First Out) ���·� �����͸� ���� �����ϴ� Ŭ����
LIFO (Last In First Out) :���Լ���, �������� ���� �����͸� ���� ���� ������.
-�ֹ��� ���ø� �׾Ƴ��� ������ ������ ����, �칰�� â�� ������ ����
 
Push(): ���ñ����� ������ �Է�
Pop(): ���ñ������� ������ ���
Peek(): ���ñ������� �������� ���� ���(�������� �Է�)�� �������� ���� ��ȯ
Count: ���ÿ� ���� ����Ǿ��մ� �������� ��
Overflow: ������ ���� á���� �߻�
Underflow: ������ ������� �߻�

 */