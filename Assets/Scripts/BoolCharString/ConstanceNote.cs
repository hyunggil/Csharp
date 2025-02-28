using UnityEngine;

public class ConstanceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //변수
        string name = "홍길동";
        name = "이순신";
        //상수
        const int AGE = 20; //정수형 상수
        //AGE = 21; 수정 불가능
        //변수, 상수 사용
        Debug.Log($"{name} + {AGE}");


        
    }

}
