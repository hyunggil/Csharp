using UnityEngine;

public class ElseIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //score가 90점 이상이면 A, 80점 이상이면 B, 70점 이상이면 c, 60점이상이면 d, 나머지f
        int score = 99;
        char grade = 'A';

        if(score >=90)  //90점이상이면
        {
            grade = 'A';
        }
        else if(score >= 80)    //80점 이상이면
        {
            grade = 'B';
        }
        else if (score >= 70) //70점 이상이면
        {
            grade = 'c';
        }
        else if (score >= 60) //60점 이상이면
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }
        Debug.Log($"{grade} 학점");
    }

}
