using UnityEngine;
//Null 연산자: ?? (null병합 연산자), ?.(null조건부 연산자)
public class NullNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //??(null 병합 연산자)
        string nullValue = null;
        string massage = "";

        //massage 변수 초기화
        /* if(nullValue == null)
         {
             massage = "null이면 새로운 값으로 초기화";

         }*/
        massage = nullValue ?? "null이면 새로운 값으로 초기화";
        Debug.Log(massage);

        // ?.(null조건부 연산자)

        int? len;           //message 길이를 저장하는 변수
        string msg = null;

        /*if(msg != null)
        {
            len = msg.Length;
        }
        else
        {
            len = null;
        }*/
        //msg 가 null이면 null을 반환, null이 아니면 ?.뒤에 있는 값 반환
        len = msg?.Length;
        msg = "안녕하세요";
        len = msg?.Length;
        Debug.Log(len);
    }
}
