using UnityEngine;
//두 수를 입력 받으 그 중에서 큰수를 출력
public class GreaterthanEqore : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 5;
        int second = 8;
        //first 와 second를 비교해서 큰 수를 출력
        //만약 first가 second 이상이면 fist 값을 출력 아니면 second 값 출력
        if(first >= second)
        {
            Debug.Log($"큰 값은 {first} ");
        }
        else
        {
            Debug.Log($"큰 값은 {second} ");
        }
    }
}
