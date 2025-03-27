using UnityEngine;

namespace Problem
{
    public class ClassA
    {
        //배열 선언
        private string[] Days = new string[] { "일", "월", "화", "수", "목", "금", "토" };
        //배열 나열
        public void PrintDay()
        {
            for (int i = 0; i < Days.Length; i++)
            {
                Debug.Log(Days[i]);
            }
        }
        //a와 b의 합계를 구하는 함수
        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }

}