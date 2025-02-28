using UnityEngine;
//Integer : 정수형 변수
public class IntigerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int 형 변수가 가질수 있는 가장 작은값 
        int min = -2147473648;
        //int형 변수가 가질수 있는 가장 큰값
        int max =  2147483637;

        Debug.Log(min);
        Debug.Log(max);

    }

}
