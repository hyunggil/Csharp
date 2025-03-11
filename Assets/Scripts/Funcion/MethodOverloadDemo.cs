using UnityEngine;

public class MethodOverloadDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hi();
        Hi("�ݰ����ϴ�.");
        Hi("�����մϴ�.", 3);
    }
    //�λ��ϴ� �Լ� �����ϱ�: Hi
    //�Ű������� ���� �Լ�
    void Hi()
    {
        Debug.Log("�ȳ��ϼ���");
    }
    //�ް������� �Է¹���  (message)�� �ִ� �Լ�
    void Hi(string message)
    {
        Debug.Log(message);
    }
    //�Ű������� �Է¹��� (message)�� �Ű� ������ ���� (count) Ƚ�� ��ŭ �λ�
    void Hi(string message, int count)
    {
        for(int i= 0; i < 3; i++ )
        {
            Debug.Log(message);
        }
    }
}
