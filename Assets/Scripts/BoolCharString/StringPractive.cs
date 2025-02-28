using UnityEngine;

public class StringPractive : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //홀수를 변수 선언하고 저장하고 문자를 버간법을 이용해서 저장된 데이터를 출력한다.
        //output
        int num = 3;
        string holsu = "홀수";

        Debug.Log(num + "은(는)" + holsu + "입니다.");
    }

}
