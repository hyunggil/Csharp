using UnityEngine;

namespace Constructor
{
    public class My
    {
        //[1] 필드 선언:
        private string name;    //이름
        int age;                //나이

        //[2]생성자 - 이름과 나이를 매개변수로 받아 필드 초기화
        public My(string _name, int _age)
        {
            this.name = _name;  //this 이 클래스 객체의 멤버다.라는뜻
            age = _age;
        }

        //[3] 메서드
        public void PrintMyInfo()
        {
            Debug.Log($"이름: {this.name}, 나이: {this.age}");
        }
    }
}