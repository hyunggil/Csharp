using UnityEngine;
//Sort(����): ��������(1,2,3,...), ��������(...,5,4,3,2,1)
public class ArraySort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arr = { 3, 2, 1, 4, 5, };
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
        Debug.Log("==================");
        //Sort =�������� ����
        System.Array.Sort(arr);

        foreach (var num in arr)
        {
            Debug.Log(num);
        }
        Debug.Log("===========");
        //Rebers - �迭�� �������� ����
        System.Array.Reverse(arr);
        foreach (var num in arr)
        {
            Debug.Log(num);
        }
    }
}
