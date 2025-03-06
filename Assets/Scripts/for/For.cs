using UnityEngine;

public class For : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      /*  for (int i = 0; i < 5; i++)
        {
            //반복실행문
            Debug.Log($"count: {i + 1}");
        }*/
     /* for(int i = 1; i <= 5; i++)
      {
            //반복실행문
            Debug.Log($"count: {i}");
      }*/

        for(int i = 1; i <6; i++)
        {
            //반복실행문
            Debug.Log($"count: {i}");
        }
    }
    //1부터 5까지 1씩 증가하면서 값을 출력 -> 5번 반복
}
