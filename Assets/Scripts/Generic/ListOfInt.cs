using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//제네릭 리스트: 배ㅕㄹ, 제네릭 리스트 비교
public class ListOfInt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]배열 : 정수형 배열 변수 선언하고 요소수 생성
        int[] arrNumbers = new int[2];

        //[2]데이터 초기화
        arrNumbers[0] = 10;
        arrNumbers[1] = 20;

        //[3]배열 사용
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            Debug.Log(arrNumbers[i]);
        }


        //제네릭 리스트 : List<T>
        //[1]int형 전용의 List  인스턴스 생성
        //[1]int형 전용의 List  인스턴스 생성
        List<int> lstNumbers = new List<int>();
        //[2] 리스트에 데이터 넣기
        lstNumbers.Add(30);
        lstNumbers.Add(40);

        //[3] 리스트 사용 : 배열 크기에 상관없이 추가로 넣을수 있다.
        for (int i = 0; i < lstNumbers.Count; i++)
        {
            Debug.Log(lstNumbers[i]);
        }
        lstNumbers.Add(50);   //<<
        for (int i = 0; i < lstNumbers.Count; i++)
        {
            Debug.Log(lstNumbers[i]);
        }
    }
}
