using UnityEngine;
//���� �����͸� �����ϴ� ����ü
//[1] ����ü ����, ����
struct BussinessCard
{
    public string name;     //���̸�
    public int age;         //�� ����
    public string address; //�� �ּ�
}

public class StructNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]����ü ������ ���� ����
        BussinessCard mycard;

        //[3] ����ü�� �����մ� �����͵��� �ʱ�ȭ
        mycard.name = "ȫ�浿";
        mycard.age = 20;
        mycard.address = "����� ������";

        //[4] ����ü ���
        Debug.Log($"�̸�: {mycard.name}, ����: {mycard.age}, �ּ�: {mycard.address}");
    }
}
