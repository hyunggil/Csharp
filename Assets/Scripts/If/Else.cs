using UnityEngine;

public class Else : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(1 != 1)
        {
            //Debug.Log("조건이 참이면 실행한다.");
        }
        else
        {
            Debug.Log("조건식이 거짓이면 실행한다.");
        }
    }
}
/*
else문
//만약 조건식이 참이면 실행문1 을 실행하고 실행문2는 실행하지 않는다,
//만약 조건식이 거짓이면 실행문1을실행하지앟고 실행문2는 실행한다.
if(조건식)
{
    //실행문1
}
else
{
    //실행문2
}
//실행문3
1.조건식이 참이면
실행문1 -> 실행문3
2. 조건식이 거짓이면
실행문2 -> 실행문3
 */