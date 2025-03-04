using UnityEngine;
//GetType : 변수으ㅣ 타입 읽어오기
public class TypeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234;
        double d = 3.14;
        string s = "안녕";
        char c = 'a';

        Debug.Log(i.GetType());
        Debug.Log(d.GetType());
        Debug.Log(s.GetType());
        Debug.Log(c.GetType());
    }

}
