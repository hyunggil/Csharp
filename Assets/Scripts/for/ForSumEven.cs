using UnityEngine;
//1���� 10������ ������ ¦���� ���� ���ϴ� ���α׷�
public class ForSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //
        int sum = 0;
        for(int i = 1; i < 11; i = i++)
        {
            sum = sum + i;
        }
           
       
        Debug.Log($"����: {sum}�̴�.");
    }

}
