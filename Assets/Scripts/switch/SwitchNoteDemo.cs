using UnityEngine;

public class SwitchNoteDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 1;
        //switch: data값을 가지고 판별
        switch(x)
        {
            case 1:
                Debug.Log("x는 1입니다.");  //실행문1
                break;
            case 2:
                Debug.Log("x는 2입니다.");  //실행문2
                break;
        }
        Debug.Log("프로그램 종료");
    }

}
/*
switch문: 조건문 - 선언문
switch(조건) : Data 값 판별
{
    case 1번:
    //실횅문1
        break;
    case 2번:
        break;
    case 3번:
        break;

    defalt: //모든case가 아니면
        //실행문
        break;
}

 */