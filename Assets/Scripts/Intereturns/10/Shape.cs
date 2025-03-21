using UnityEngine;

namespace Inheritance10
{
    //추상클래스 : 도형을 관리하는 클래스
    //강제 기능 : 도형의 면적을 구하는 메서드글 구현하도록 지정
    public abstract class Shape
    {
        //추상메서드
        public abstract double GetArea();
    }
    
}