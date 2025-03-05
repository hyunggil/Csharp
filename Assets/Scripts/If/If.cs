using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
//만약 score가 60 점 이상이면 "합격"이라고 출력하시오.
//score 61점
public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61;
        if(score >=60)  //조건문이 참이면 블록안에 있는 실행문을 실행
        {
            Debug.Log("합격");
        }
    }
}
/*
if: 조건문
조건식이 참일 때만 실행문이 실행됩니다.
조건문이 거짓이면 실행문을 실행 하지 않습니다.
//만약 조건식이 참이면 {} 안에 있는 실행문을 실행하라
if(bool)
{
    //실행문:
    //실행문2:
    //.....
}

 */