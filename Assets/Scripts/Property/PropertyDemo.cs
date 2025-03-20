using UnityEngine;

namespace Property
{
    public class PropertyDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[2] public 메서드 Get, Set 이용 : 빨간색 자동차
            Car car1 = new Car();
            car1.SetColor("Red");
            Debug.Log(car1.GetColor());

            //
            Car car2 = new Car();
            car2.Color = "White";
            Debug.Log(car2.Color);
            //[3] 읽기 전용 속성
            Car car3 = new Car();
            //car3.Maker = "대우자동차"; //읽기 전용이라 바꿀수가 없다.
            Debug.Log(car3.Maker);

            //[4] 자동속성, 축약형
            Car myCar = new Car();
            myCar.Name = "붕붕이";
            Debug.Log(myCar.Name);

        }
    }
}