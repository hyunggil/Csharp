using UnityEngine;
//methodOverload(�޼��� �����ε�, �Լ� ���� ����)
//������ �̸��� �޼��带 �Ű� ������ �޸��ؼ� ������ �����ϴ� ��
public class MethodOverroadNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintNumber(1234);
        PrintNumber(1234l);
        PrintNumber(1234f);
    }
    //�Ű������� ���ڸ� �Է¹��� ����ϴ� �Լ� : PrintNumber
    //int Ÿ���� ������ �Ű������� �Է¹޾� ���
    void PrintNumber(int number)
    {
        Debug.Log($"int32 {number}");

    }
    //long Ÿ���� ������ �Ű������� �Է¹޾� ���
    void PrintNumber(long number)
    {
        Debug.Log($"int64 {number}");
    }
    //float Ÿ���� �Ǽ��� �Ű������� �Է¹޾� ���
    void PrintNumber(float number)
    {
        Debug.Log($"�Ǽ��� {number}");
    }
}
