using UnityEngine;
//명함 데이터를 관리하는 구조체
//[1] 구조체 정의, 선언
struct BussinessCard
{
    public string name;     //고객이름
    public int age;         //고객 나이
    public string address; //고객 주소
}

public class StructNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]구조체 형식의 변수 선언
        BussinessCard mycard;

        //[3] 구조체의 속해잇는 데이터들의 초기화
        mycard.name = "홍길동";
        mycard.age = 20;
        mycard.address = "서울시 강동구";

        //[4] 구조체 사용
        Debug.Log($"이름: {mycard.name}, 나이: {mycard.age}, 주소: {mycard.address}");
    }
}
