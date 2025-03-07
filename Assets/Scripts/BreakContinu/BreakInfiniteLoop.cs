using UnityEngine;
// break;로 무한루프를 빠져 나오기
public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //무한루프 -문한반복
        /*     for(; ;)
             {

             }*/
        /*  while(true)
          {

          }*/
        int number = 0;
        while (true)    //무한루프
        {
            //반복실행문
            Debug.Log(number);
            number++;
            if(number >= 5)
            {
                break;
            }
        }
    }
}
