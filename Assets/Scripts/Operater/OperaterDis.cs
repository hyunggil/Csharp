using UnityEngine;
//Operator (연산자) : +,-,*,/ 등 연산을 진행하는 키워드
public class OperaterDis : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(3 + 5);
        Debug.Log(3 - 5);
        Debug.Log(3 * 5);
        Debug.Log(3 / 5);

        //value를 선언하고 0으로 초기화
        int value = 0;

        value = 8;  //value라는 변수에 8값을 저장 => 8
        value = +value;
        Debug.Log(value); // ->?
        value = -8;  //valeu 변수에 8을저저장
        value = +value;
        Debug.Log(value);
        value = 8;
        value = -value;
        Debug.Log(value);
        value = -8;
        value = -value;
        Debug.Log(value);

    }

}
