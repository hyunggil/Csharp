using UnityEngine;

namespace Method
{
    //[3] 반환형 전달 방법 (Out int numver)
    public class PrameterOut : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int number;

            PrintNumber(out number);

            Debug.Log($"[3] {number}"); //1234

        }
        //정수형 out number를 매개 변수로 입력받아 출력하는 함수
        //반환형 매개변수 전달 방식
        //참조형 방식과 동일, 함수 내부에서 반드시 초기화(값)을 설정
        void PrintNumber(out int number)
        {
            
            number = 1234;
            Debug.Log($"[2] {number}"); //1234
        }
    }
}