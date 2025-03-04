using UnityEngine;

public class Inttobite : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int형 변수 x를 선언하고 255로 초기화
        int x = 255;

        //byte향 변수 y를 ㅅ헌언하고 x의 갑으로 초기화
        byte y = (byte)x;

        Debug.Log(x + "->" + y);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
