using UnityEngine;
//GetType : �������� Ÿ�� �о����
public class TypeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234;
        double d = 3.14;
        string s = "�ȳ�";
        char c = 'a';

        Debug.Log(i.GetType());
        Debug.Log(d.GetType());
        Debug.Log(s.GetType());
        Debug.Log(c.GetType());
    }

}
