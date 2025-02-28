using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        double pi = 3.141592; //64비트 실수형 데이터 형식 선언 및 초기화
        float f = 3.14f; //32비트 실수형 데이터 형식 선언 및 초기화
        decimal d = 12.34m; // 128비트 실수형 데이터 형식 선언 및 초기화

        Debug.Log(pi);
        Debug.Log(f);
        Debug.Log(d);

        double doubleMin = double.MinValue;
        double doubleMax = double.MaxValue;

        Debug.Log("더블 최소값: " + doubleMin);
        Debug.Log("더블 최대값: " + doubleMax);

        float floatMin = float.MinValue;
        float floatMax = float.MaxValue;

        Debug.Log("float최소값: " + floatMin);
        Debug.Log("float최대값: " + floatMax);

        decimal decimalMin = decimal.MinValue;
        decimal decimalMax = decimal.MaxValue;

        Debug.Log("decimal 최대값: " + decimalMin);
        Debug.Log("decimal 최소값:" + decimalMax);
    }

}
