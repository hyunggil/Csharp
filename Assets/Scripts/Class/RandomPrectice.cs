using System.Globalization;
using UnityEngine;

//로또 번호 생성기
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
 [Q]로또 번호 생성기를 만들어라
[1] 6개 번호
[2] 1-45번 사이의 랜덤번호
[3] 중복된 숫자가 나오면 안된다. 

[out put] -조건에 맞은 번호 6개 출력

 
 
 */