using UnityEngine;

namespace Constructor
{
    public class ConstructForwording : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Money 클래스의 인스턴스 생성
            Money basic = new Money();
            //Money 클래스의 인스턴스 생성매개변수가 있는 인스턴스 생성자 호출
            Money bonus = new Money(2000);
        }
    }
}