using UnityEngine;

public class StringDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "홍길동";

        Debug.Log("안녕하세요" + name + "입니다.");

        string multiLine = @"
        안녕하세요
        반갑습니다.";
        Debug.Log(multiLine);

    }

}
