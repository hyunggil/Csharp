using UnityEngine;
//1부터 10까지의 정수중 짝수의 합을 구하는 프로그램
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
           
       
        Debug.Log($"답은: {sum}이다.");
    }

}
