using UnityEngine;
//��� �Լ� : �Ϲ��� �ڽ��� �ڵ� ��� �ȿ��� �ڽ��� �ٽ� ȣ��(��� ȣ��) �ϴ� �Լ�
//-����Լ� �Ű�����: �Ű������� ����, ������ �ȴ�.
//-��� �Լ� �ڵ� ��� �ȿ��� ��� �Լ��� ���� �� ���ִ� ������ �ʿ��ϴ�.
//���丮�� ���ϴ� �˰���(4!)



public class RecusionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //4! = 1*2*3*4
        Debug.Log(4 * 3 * 2 * 1);
        //for factorial
        Debug.Log(Factorial(4));
        
    }
    //for���� �̿� factorial�� ���ϱ�
    /*int Factorialfor(int n)
    {
        int result = 1;
        for(int i = 1; i <=n; i++)
        {
            result = result * i;
        }
        return result;
    }*/
    //3�� �����ڸ� �̿��� Factorial �����
    int factor(int n)
    {
        return (n > 1) ? n * factor(n - 1) : 1;
    }
    int Factorial(int n)
    {
        //���� ���� �κ�
        if(n == 1 || n == 0)
        {
            return 1;
        }
        //��� ȣ�� �κ�
        return n * Factorial(n - 1);
    }

}
//��� �Լ��� �̿� factorial�� ���ϱ�
