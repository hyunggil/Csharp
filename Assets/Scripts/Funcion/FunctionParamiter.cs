using UnityEngine;
//Parameter(�Ű� ����)
public class FunctionParamiter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]�Ű������� �ִ� �Լ� ȣ��(���)�ϱ�
        ShowMessage("�ȳ��ϼ���");

        ShowMessage("�ȳ�");
    }
    //[1]�Ű������� �ִ� �Լ� ����(�����ϱ�)
    //�Ű������� ���� ���� ���ڿ��� ����ϴ� �Լ�
    void ShowMessage(string message)
    {
        Debug.Log(message);
    }
}
