using UnityEngine;

public class GetSumtwoNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]두수의 (3,4)합을 반환값을 받아 출력하기
        int result = GetSum(3, 4);
        Debug.Log(result);

    }
    //[1]두수의 합을 구하는 함수 만들기 - 매개변수, 반환갑 이용
    //매개변수로 들어온 두 정수의 합을 반환하는 정수 선언
    int GetSum(int x, int y)
    {
        //int sum = x + y;
        //return sum;
        return (x + y);
    }
}
