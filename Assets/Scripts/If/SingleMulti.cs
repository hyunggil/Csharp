using UnityEngine;
//실행문: 단문(1개), 복문(2개 이상)
public class SingleMulti : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //만약 조건식이 참이면() 안에 있는 실행문을 실행하라
        /*
        fi(조건식)
        {
        실행문
        실행문
        ....
        }

         */
        //단문은 {} 실행문이 1개
        if(1 == 1)
        {
            Debug.Log("단문");
        }
        if (1 == 1)
            Debug.Log("단문2");

        if (1 == 1) Debug.Log("단문3");

        //복문
        if (1 == 1)
        {
            Debug.Log("복문1");
            Debug.Log("복문2");
        }

    }

}
/*
if()
{

}



 */