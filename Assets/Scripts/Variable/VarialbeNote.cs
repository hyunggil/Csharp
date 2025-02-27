using UnityEngine;

//Variable (변수): 프로그램에서 사용하는 데이터를 저장해 놓는 그릇
public class VarialbeNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]변수 만들기(선언)
        int i;  //i이름으로 (정수형)변수를 만듦
        i = 1234; //변수에 값을 저장한다(대입한다.할당,초기화)
        Debug.Log(i); //변수에 들어있는 값을 사용하기(참조)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
