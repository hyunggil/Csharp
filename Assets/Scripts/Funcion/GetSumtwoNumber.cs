using UnityEngine;

public class GetSumtwoNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]�μ��� (3,4)���� ��ȯ���� �޾� ����ϱ�
        int result = GetSum(3, 4);
        Debug.Log(result);

    }
    //[1]�μ��� ���� ���ϴ� �Լ� ����� - �Ű�����, ��ȯ�� �̿�
    //�Ű������� ���� �� ������ ���� ��ȯ�ϴ� ���� ����
    int GetSum(int x, int y)
    {
        //int sum = x + y;
        //return sum;
        return (x + y);
    }
}
