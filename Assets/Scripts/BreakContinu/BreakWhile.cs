using UnityEngine;
//1���� 10������ ������ ���� ���ϴ� ���α׷� ����
//���� ���� 22 �̻��� �Ǹ� break;
public class BreakWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int sum = 0;
        int goal = 22;

        int i = 1;

        while(i <= n)
        {
            sum += i;
            if (sum >= goal)
            {
                break;
            }
            i++;
        }
       
        
        Debug.Log(sum);
        
    }

}
