using UnityEngine;

namespace Inheritance
{
    //부모클래스의 자식클래스 이라고 선언
    // class 자식클래스이름 : 부모클래스이름
    public class Child : Parent
    {
        public void Bar()
        {
            Debug.Log("자식클래스의 멤버 호출");
        }
    }
}