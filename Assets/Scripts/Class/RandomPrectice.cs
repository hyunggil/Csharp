using System.Globalization;
using UnityEngine;

//�ζ� ��ȣ ������
public class RandomPrectice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        System.Random random = new System.Random();
        for (int i = 0; i < 6; i++)
        {
            Debug.Log(random.Next(1,26));

        }
    }

 }
/*
 [Q]�ζ� ��ȣ �����⸦ ������
[1] 6�� ��ȣ
[2] 1-45�� ������ ������ȣ
[3] �ߺ��� ���ڰ� ������ �ȵȴ�. 

[out put] -���ǿ� ���� ��ȣ 6�� ���

 
 
 */