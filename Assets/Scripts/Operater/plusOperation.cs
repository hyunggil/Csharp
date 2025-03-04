using UnityEngine;
// + :더하기 연산자
// %: 나머지 연산
public class plusOperation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 10;
        int j = 20;
        int k = i + j;  //더하기 연산
        Debug.Log(k);

        float f = 3.14f;
        float g = 3.14f;
        float e = f - g;
        Debug.Log(e);   //빼기 연산

        long a = 100;
        long b = 200;
        long c = a * b;
        Debug.Log(c);

        double l = 1.5d;
        double m = 0.5d;
        double n = l / m;
        Debug.Log(n);

        int x = 5;
        int y = 3;
        int z = x % y;
        Debug.Log(z);
    }

}
