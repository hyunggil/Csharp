using UnityEngine;

namespace Inheritance09
{
    //추상클래스: abstract : 자신을 상속 받은 자식 클래스에서
    //강제로 지정한 기능(메서드)를 구현 하도록 한다.
    //추상메서드: 지정한기능(메서드)
    //public abstract void (추상메서드 이름)();
    public abstract class GeneralManager
    {
        //추상 메서드 : abstract 가 붙고 메서드 구현부분(코드블록, 본문)을 생략
        public abstract void SayTalk();
    }

    //추상클래스(GeneralManager)를 상속받는 자식 클래스
    public class Person : GeneralManager
    {
        //상속받은 추상메서드 구현부분
        //public override void (추상메서드 이름)()
        public override void SayTalk()
        {
            Debug.Log("상속 받은 추상 메서드를 구현한다.");
        }
    }
}