using UnityEngine;
//Operator (������) : +,-,*,/ �� ������ �����ϴ� Ű����
public class OperaterDis : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(3 + 5);
        Debug.Log(3 - 5);
        Debug.Log(3 * 5);
        Debug.Log(3 / 5);

        //value�� �����ϰ� 0���� �ʱ�ȭ
        int value = 0;

        value = 8;  //value��� ������ 8���� ���� => 8
        value = +value;
        Debug.Log(value); // ->?
        value = -8;  //valeu ������ 8��������
        value = +value;
        Debug.Log(value);
        value = 8;
        value = -value;
        Debug.Log(value);
        value = -8;
        value = -value;
        Debug.Log(value);

    }

}
