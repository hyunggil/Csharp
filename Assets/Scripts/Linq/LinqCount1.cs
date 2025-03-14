using System.Linq;
using UnityEngine;

public class LinqCount1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bool형 배열 변수에서 true 값이 개수, false 값의 개수 구하기
        bool[] blns = { true, false, true, false, true };

        //전체 요소수 구하기
        Debug.Log(blns.Count());
        //true 값의 갯수
        Debug.Log(blns.Count(b => b == true));  //3
        Debug.Log(blns.Count(a => a == false)); //2
    }
}
