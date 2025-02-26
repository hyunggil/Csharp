//[1] 네임스페이스 선언부
using UnityEngine; //현재 Filenew클래스 파일에서unityEngine 네임스페이스를 사용하겠다.

//[2]클래스 선언부 이 클래스의 이름은 Filenew
public class Filenew : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
        //[3]start메서드 선언문 : 프록그램을 실행할때 딱 1번만 호출
    {
        //[5]명령문 콘솔창 출력명령문
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    //[4]update 메서드 선언 : 프로그램 시작후에 매 프래임마다 실행
    void Update()
    {

    }
}
