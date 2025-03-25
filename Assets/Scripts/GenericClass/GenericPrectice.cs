using UnityEngine;

namespace GenericClass
{
    public class GenericPrectice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //NyList 제네릭클래스 인스턴스 생성 - int 전용
            MyList<int> numbers = new MyList<int>(3);
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            for (int i = 0; i < numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }
            //NyList 제네릭클래스 인스턴스 생성 - string 전용
            MyList<string> names = new MyList<string>(3);
            names[0] = "홍길동";
            names[1] = "백두산";
            names[2] = "장길산";

            foreach (var name in names)
            {
                Debug.Log(name);
            }
        }
    }
}