using UnityEngine;

namespace PrivatePublic
{
    //일요일-토요일까지 출력하는 함수 만들기
    public class Scadule
    {
        //[1] 배열 필드 선언
        string[] weekDays = { "Sun", "Mon", "Tue", "Wen", "Thu", "Fri", "Sat" };

        //[2] 요일 출력하기
        public void PrintWeekDays()
        {
            for (int i = 0; i < weekDays.Length; i++)
            {
                Debug.Log(weekDays[i]);
            }
        }

    }
}
