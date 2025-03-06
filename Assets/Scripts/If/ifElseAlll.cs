using UnityEngine;

public class ifElseAlll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //하나의 정수를 입력받아서 짝수인지 홀수인지 판별
        int number = 21;
        //짝수판별
        if (number % 2 == 0)
        {
            Debug.Log($"{number}는 짝수");
        }
        if(number % 2 != 0) //홀수 판별
        {
            Debug.Log($"{number}는 홀수 입니다.");
        }
        else
        {
            Debug.Log($"{number}는 짝수 입니다.");
        }
        if (number % 3 == 0)
        {
            Debug.Log($"{number}는 3의 배수");
        }
        else if (number % 5 == 0)
        {
            Debug.Log($"{number}는 5의 배수");
        }
        if(number % 7 == 0)
        {
            Debug.Log($"{number}는 7의 배수");
        }
    }

}
