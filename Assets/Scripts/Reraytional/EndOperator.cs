using UnityEngine;
//AndOperator(And ������) : && �Ѵ� ���϶��� ��
//���: true, false
public class EndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] �Ѵ� ���϶��� ��
        Debug.Log(true && true);    // => true
        //[2] ���� �ϳ��� �����̶��
        Debug.Log(true && false);   // => false
        Debug.Log(false && true);   // => false
        //[3] �Ѵ� ����
        Debug.Log(false && false);   // => false
    }
}
