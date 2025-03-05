using UnityEngine;
//else 중첩문
public class ElseNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        char input = '1';
        //[1] input 'y' 이면 "yes" 출력
        //[2] input 'n' 이면 "no" 출력
        //[3] input 그외 나머지 이면 cancel 처리
        if(input == 'y')
        {
            Debug.Log("yes");
        }
        else
        {
            if(input == 'n')
            {
                Debug.Log("no");

            }
            else
            {
                Debug.Log("cancel");
            }
        }
    }
}
