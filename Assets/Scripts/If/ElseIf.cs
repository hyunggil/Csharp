using UnityEngine;

public class ElseIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //score�� 90�� �̻��̸� A, 80�� �̻��̸� B, 70�� �̻��̸� c, 60���̻��̸� d, ������f
        int score = 99;
        char grade = 'A';

        if(score >=90)  //90���̻��̸�
        {
            grade = 'A';
        }
        else if(score >= 80)    //80�� �̻��̸�
        {
            grade = 'B';
        }
        else if (score >= 70) //70�� �̻��̸�
        {
            grade = 'c';
        }
        else if (score >= 60) //60�� �̻��̸�
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }
        Debug.Log($"{grade} ����");
    }

}
