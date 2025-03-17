//네임스페이스 선언부: 
using UnityEngine;  //UnityEngine 네임스페이스에 있는 클래스를 가져다 사용한다.
using Foo;
using Bar;

//NameSpace(네임스페이스): 
//1. 클래스(사용자 정의 형식)등 들을 서로 관련있는(비슷한 기능) 것들끼리 묶어서 관리
//2. 같은 이름의 충돌을 방지
public class NameSpaceDestiption : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]Foo네임스페이스의 Car클래스 호출
        //Car 객체 만들기
        Foo.Car fooCar = new Foo.Car();
        fooCar.Go();

        //[2]Bar네임스페이스의 Car클래스 호출
        //Car 객체 만들기
        Bar.Car barCar = new Bar.Car();
        barCar.Go();
    }
}
/*
namespace 선언
 
 
 */