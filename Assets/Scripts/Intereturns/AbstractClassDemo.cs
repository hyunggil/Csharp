using UnityEngine;

namespace Inheritance08
{

    public class AbstractClassDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //추상클래스는 인스턴스(객체)를 만들 수 없습니다
            //ParentClass parent = new ParentClass();
            ChildClass child = new ChildClass() { Id = 1, Active = true, Name = "홍길동" };
            if(child.Active == true)
            {
                Debug.Log($"{child.Id} - {child.Name}");
            }
        }
    }
}
/*
Abstract Class(추상클래스)
: 자신을 상속 받는 자식클래스에서 강제로 기능을 추가하도록 한다
: 자식클래스는 부모클래스가 지정한 기능을 구현하도록 강제한다(무조건구현)
: 추상클래스는 인스턴스(객체)를 만들 수가 없습니다
: 다른클래스의 부모클래스만 사용이 가능하다

추상클래스 형식
public abstract class (추상클래스이름)
{

}
 
*/