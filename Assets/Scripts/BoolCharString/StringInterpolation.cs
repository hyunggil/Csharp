using UnityEngine;
//String Interpolation (문자형 보간법)
public class StringInterpolation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string massage = "문자열 보간법";

        Debug.Log("massage: " + massage);   //[1] 문자열 더하기 연산
        Debug.Log($"massage: {massage}");   //[2] 문자열 보간법으로 출력

        //string.Format
        string msg = string.Format("{0}님, {1}", "홍길동", "안녕하세요");
        Debug.Log(msg);

    }

}
