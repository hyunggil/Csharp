using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int max = GetMax(3, 5);
        Debug.Log($"3�� 5�� ū���� {max}�̴�.");
        int min = GetMin(-3, -5);
        Debug.Log($"-3�� -5�� ���� ���� {min}�̴�.");
    }
   int GetMax(int x, int y)
    {
        /*int maxvalue;
        if(x > y)
        {
            maxvalue = x;
        }
        else
        {
            maxvalue = y;
        }
        return maxvalue;*/
        //3�� ������
        //int maxValue = (x > y) ? x : y;
        //return maxValue;

        //return (x > y) ? x : y;
        if(x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
        
    }
    int GetMin(int a, int b)
    {
        if(a < b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
/*
1. �Ű������� �Է¹��� �ΰ��� ������ ū���� ��ȯ �ϴ� �Լ�
2. �Ű������� �Է¹��� �ΰ��� ������ �������� ��ȯ �ϴ� �Լ�
3. 3,5 �� �Է� �޾� ū�� ����ϱ�
4. -3, -5 �� �Է¹޾� �������� ����ϱ�
[output]
3�� 5�� ū ���� (��ȯ��) �̴�.
-3�� -5 �� ���� ���� (��ȯ��) �̴�.
 */
