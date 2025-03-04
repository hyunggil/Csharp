using UnityEngine;
//Postfixoperator (후위 즈암(++,--) 연산자): 같은 라인에서 연산하는 우선 순위가 가장 낮은 연산자
public class PostfixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = x++;

        Debug.Log("x: " + x);   //x는 4
        Debug.Log("y: " + y);   //y는 3
    }
}
