using UnityEngine;
//LogicalOperator (논리 연산자) - &&, ||, !
//OrOperator (Or 연산자), || ,하나라도 참이면 참.
//결과 : true, false
public class OrOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 들다 참일때
        Debug.Log(true || true);    // =>true
        //[2] 둘중 하나가 참일때
        Debug.Log(true || false);   // =>true
        Debug.Log(false || true);   // =>true
        //[3] 둘다 거짓일때
        Debug.Log(false || false);  // =>false
    }
}
