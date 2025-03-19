using UnityEngine;

namespace Method
{
    public class MethodPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog 쿨래스의 인스턴트생성
            Dog cat = new Dog();

            cat.Eat();  //[1] public 메서드 호출가능
            cat.weight = 30;    //[2] public 필드 접근 가능
            Dog.Drink();    //static은 클래스.객체 로 호출
            //cat.Digest(); //사용불가
        }
    }
}