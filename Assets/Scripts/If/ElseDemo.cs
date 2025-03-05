using UnityEngine;
//만약 score가 60점 이상이면"합격" 이라고 출력하고,
//아니면 "불합격" 이라고 출력
//score 61점
public class ElseDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61; //[1]
        if(score >= 60)
        {
            Debug.Log("합격"); //[2]
        }
        else
        {
            Debug.Log("불합격");   //[3]
        }
        Debug.Log("종료");    //[4]
    }
}
