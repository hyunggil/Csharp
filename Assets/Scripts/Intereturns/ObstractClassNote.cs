using UnityEngine;

namespace Inheritance10
{
    public class ObstractClassNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Squre의 클래스의 인스턴스 생성
            Squre squre = new Squre(10);
            Debug.Log(squre.GetArea());

            //Circle클래스의 인스턴스 생성
            Circle circle = new Circle(10);
            Debug.Log(circle.GetArea());

        }
    }
}