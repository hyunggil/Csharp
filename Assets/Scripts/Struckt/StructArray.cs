using UnityEngine;
//[1] 구조체 정의, 선언: 고객의 데이터를 관리하는 구조체
struct UserInfo
{
    public string name;
    public int age;
    //......
}

public class StructArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]구조체 변수 선언
        UserInfo info;
        //[2]초기화
        info.name = "홍길동";
        info.age = 20;
    
    }
    //고객의 명단을 출력하는 함수
    void PrintUserInfo(string name, int age)
    {
        Debug.Log($"{name}님의 나이는 {age}살 입니다.");
    }
}
