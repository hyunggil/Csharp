using UnityEngine;
//var : �Ͻ������� ����ȭ�� ���� ����
// var ����� ������ �ʱ�ȭ�� �ݵ�� �Ѵ�.
public class Var : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var name = "ȫ�浿";   //������ �ԷµǴ� ��("ȫ�浿")�� ���� ���� name������ string�������� ����

        var version = 8.0;    //������ �ԷµǴ� ��(8.0)�� ���� version�̶�� ������ double������ ����

        var car = 1;    //������ �ԷµǴ� ��(1)�� ���� 1�̶�� ������ int������ ����

        Debug.Log(name);
        Debug.Log(name.GetType());

        Debug.Log(version);
        Debug.Log(version.GetType());

        Debug.Log(1);
        Debug.Log(1.GetType());

        Debug.Log(car);
        Debug.Log(car.GetType());
    }
}
