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
-��Ģ ������ ���ϴ� �Լ� �����

�ΰ��� ������ �Է¹޾� +,-,*,/,% ����ϸ�
������� ��ȯ�ϴ� �Լ� �����
�Է°�: 5,3
[output]
 */