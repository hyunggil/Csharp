using UnityEngine;

using Korea.Suwon;  //Korea.Suwon에 있는 클래스를 가져다 사용하겠다.
//별칭을 사용해서 사용하기, Korea.Suwon을 Su 네임스페이스 별칭을 만들어 사용하기
using Su = Korea.Suwon;
public class NameSpaceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 네임스페이스 이름 정체를 지정(붙여서)해서 사용하기
        Korea.Seoul.Car se = new Korea.Seoul.Car();
        se.Run();   //서울자동차가 달린다.
        Korea.Suwon.Car su = new Korea.Suwon.Car();
        su.Run();   //수원자동차가 달린다.

        //[2]네임스페이스 선언부에 using을 선언하여 사용하기
        Car suwon = new Car();
        suwon.Run();    //수원 자동차가 달립니다.

        //[3]
        Su.Car seoul = new Car();
        seoul.Run();

        //truck 호출하기
        Korea.Seoul.Truck truck = new Korea.Seoul.Truck();
        truck.Run();
    }
}
