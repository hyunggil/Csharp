using UnityEngine;
//DefaultParameter(�⺻ �Ű� ����, ������ �Ű�����) : �Ű����� ����� �ʱ�ȭ�� �Ѵ�.
//������ �Ű������� �Լ� ȣ��� ������ �����ϴ�. ������ �ʱ�ȭ �� ���� ���Ǿ� ����.
public class DepoltParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�Ű������� ���� �Լ�ȣ��
        PrintMessage();
        //�Ű������� �ִ� �Լ�ȣ��
        string error = "�����";
        PrintError(error);
        PrintError("�����", 4);
        PrintError("�����", 1);
    }
    //Message�� ����ϴ� �Լ�
    void PrintMessage()
    {
        string message = "�����";
        Debug.Log(message);
    }
    void PrintError(string message, int level = 1)
    {
        Debug.Log($"���� {message}����:{level}");
    }
    
}
