using UnityEngine;

// RelationalOperator (������ ������, �� ������.)
// < (����), <=(�۰ų� ����) ,>(ŭ) >=(ũ�ų� ����), == (����), !=(�ٸ�)
// ��� : true(��), false(����)
public class ReraytionalOperater : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y);   //x(3)�� y(5)���� �۳�? -> true
        Debug.Log(x <= y);   //x(3)�� y(5)���� �۳�? -> true
        Debug.Log(x > y);   //x(3)�� y(5)���� �۳�? -> false
        Debug.Log(x >= y);   //x(3)�� y(5)���� �۳�? -> false
        Debug.Log(x == y);   //x(3)�� y(5)���� �۳�? -> false
        Debug.Log(x != y);   //x(3)�� y(5)���� �۳�? -> true

        Debug.Log("AAA" == "aaa");  //false
    }
}
