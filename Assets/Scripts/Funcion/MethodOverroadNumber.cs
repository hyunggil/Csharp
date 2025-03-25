using UnityEngine;
//methodOverload(메서드 오버로드, 함수 다중 정의)
//동일한 이름의 메서드를 매개 변수를 달리해서 여러개 생성하는 것
public class MethodOverroadNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*PrintNumber(1234);
        PrintNumber(1234l);
        PrintNumber(1234f);
        PrintNumber(3.14);*/

        PrintNumber<int>(1234);
        PrintNumber<long>(1234L);
        PrintNumber<float>(1234f);
        PrintNumber<double>(3.14);
    }
    //제네릭 메서드
    void PrintNumber<T>(T number)
    {
        Debug.Log($"{number}");
    }

    //매개변수로 숫자를 입력받아 출력하는 함수 : PrintNumber
    //int 타입의 정수를 매개변수를 입력받아 출력
    void PrintNumber(int number)
    {
        Debug.Log($"int32 {number}");

    }
    //long 타입의 정수를 매개변수를 입력받아 출력
    void PrintNumber(long number)
    {
        Debug.Log($"int64 {number}");
    }
    //float 타입의 실수를 매개변수를 입력받아 출력
    void PrintNumber(float number)
    {
        Debug.Log($"실수형 {number}");
    }
    void PrintNumber(double number)
    {
        Debug.Log($"더블형 {number}");
    }
}
