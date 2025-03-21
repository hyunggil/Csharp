using UnityEngine;

namespace Inheritance04
{
    public class InheritanceClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ParentClass 클래스의 인스턴스 생성
            ParentClass parent = new ParentClass();
            //parent.PrintMessage();    //사용불가
            Debug.Log(parent.ToString());

            //ChildClass 클래스의 인스턴스 생성
            ChildClass child = new ChildClass();
            child.PrintMessage2();  //사용 가능하다.

            //SubClass 클래스의 인스턴스 생성
            SubClass sub = new SubClass();
            //sub.PrintLog();   //접근 불가능
            sub.PrintDebug();
        }
    }
}
/*
접근 제한자 : public, pirvate, protected
protected : 상속받은 자식 클레스{} 코드블록 안에서만 접근 가능, 사용가능

public : 외부클래서에서 접근, 사용가능
private : 외부 클래스에서 접근, 사용 불가능
protected : private 와 동일, 단, 상속받은 자식 클래스의 코드블록 안에서는 접근가능
 
*/