using UnityEngine;
// + : ���ϱ� ������ �߰����
public class EditionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello" + "world!!!");    //���ڿ� ���ϱ�
        Debug.Log("Hi" + " " + "EveryOne"); //���ڿ� ���ϱ� ���ڿ�
        Debug.Log("123" + "456");   //���ڿ� + ���ڿ�
        Debug.Log("123" + 456); //���ڿ� + ���� =>���ڿ�

        Debug.Log(123 + "456" + 789 + 890); //���� + ���ڿ� =>���ڿ�
        Debug.Log(123 + 456);   //���� + ���� => ����

        Debug.Log("123" + true);    //���ڿ� + bool�� => ���ڿ�

        //Debug("123" - 456);   //����� ����

    }

}
