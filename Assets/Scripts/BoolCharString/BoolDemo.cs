using UnityEngine;
// bool (불) : 불형, 논리자료형, 참(true), 거짓(false) 값만 저장한다.
public class BoolDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bool 번수 선언하고 초기화
        bool bin = true;

        Debug.Log("bin: " + bin);

        bool isOut = false;

        Debug.Log("isOut: " + isOut);

    }

}
