using UnityEngine;
//Postfixoperator (���� ���(++,--) ������): ���� ���ο��� �����ϴ� �켱 ������ ���� ���� ������
public class PostfixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = x++;

        Debug.Log("x: " + x);   //x�� 4
        Debug.Log("y: " + y);   //y�� 3
    }
}
