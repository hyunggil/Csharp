using UnityEngine;

//�޸��� ����Ͽ� ���� ������ ������ ���� ���� ������ �����
public class VariableComma : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number1;
        int number2;
        int number3;

        number1 = 1;
        number2 = 2;
        number3 = 3;

        Debug.Log(number1 + "," + number2 + "," + number3);

        //�޸��� �������� ������ ���ٿ� ����
        //a,b,c ,���� �������� �������¿��� ó������ ���� �����Ҷ� �ʱ�ȭ
        int a, b, c;

        a = 10;
        b = 10;
        c = 10;

        Debug.Log(a + "," + b + "," + c);

        a = b = c = 10;

        Debug.Log(a + "," + b + "," + c);

    }

}
