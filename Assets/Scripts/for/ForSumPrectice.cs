using UnityEngine;

public class ForSumPrectice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;
        for(int i = 1; i < 101; i = i+3)
        {
            sum = sum + i;
        }
        Debug.Log($"���� {sum}");
        int sum1 = 0;
        for(int j = 1; j < 101; j = j+4)
        {
            sum1 = sum + j;
        }
        Debug.Log($"����{sum + sum1}");
    }

}
/*
1���� 100���� ���� �߿��� 3�� ��� �Ǵ� 4�� ����� ���ؼ� ���ϴ� ���α׷� ����
 */