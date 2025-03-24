using UnityEngine;

namespace Override
{
    public enum CarType
    {
        전기,
        내연기관
    }

    //부모클래스 - 추상클래스(인스턴스 생성불가)
    public abstract class CarBase
    {
        public abstract void Left();    //추상메서드, 본문(구현내용) 없음

        //public(접근제한자) -> 자식클래스와 외부 모든 클래스에 접근, 사용 가능
        public void Back() => Debug.Log("후진한다");

        //접근제한자 protected - 자식클래스에서만 접근, 사용가능
        //접근제한자 private - 자식클래스 포함 외부 모든 클래스에서 접근불가
        //                    private를 선헌한클래스코드 브록 안에서만 사용가능
        protected string LeftMessage { get; private set; } = "좌회전한다";
    }

    //자식클래스
    public class Car : CarBase
    {
        //모든 자동차에 공통 속성
        public CarType Style { get; private set; }

        //생성자 - 매개변를 입력받아 자동차 CarType 초기화
        public Car(CarType cType)
        {
            //this키워드로 자신의(객체) 멤버에 접근(생략가능)
            this.Style = cType;
        }
        public void Go() => Debug.Log("달린다");

        //부모의 추상메서드를 실제 코드 구현,재정의
        public override void Left()
        {
            //base 키워드를 부모(객체) 멤버에 접근(public, protected)
            Debug.Log(base.LeftMessage);
        }
    }

    //손자 클래스
    public class HyunDai : Car
    {
        public HyunDai() : this(CarType.내연기관) { }

        public HyunDai(CarType carType) : base(carType) { }
    }
    public class Tesla : Car
    {
        public Tesla() : this(CarType.전기) { }
        public Tesla(CarType carType) : base(carType){ }

    }
    //sealed(봉인) 키워드를 통해 봉인 클래스 설정 -  더이상 상속이 안된다.
    public sealed class Mirea : Car
    {
        public Mirea() : this(CarType.전기) { }
        public Mirea(CarType carType) : base(carType){ }

        public new void Go() => Debug.Log("날아다닌다");
    }

    //public class Future : Mirea { }
}