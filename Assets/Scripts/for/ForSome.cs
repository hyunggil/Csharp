using UnityEngine;

public class ForSome : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1���� 20������ ���� ���ϴ� ���α׷� ����
        int n = 100;
        int sum = 0;
        for(int i = 1; i < n+1; i++)
        {
            sum = sum + i;
        
        }
        Debug.Log($"���� : {sum}�̴�.");
    }

}
