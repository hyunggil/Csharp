using UnityEditor.Search;
using UnityEngine;

public class FuncionDiscription : MonoBehaviour
{
    //[1]Show �޼���(�Լ�) ����, ����
    void Show()
    {
        Debug.Log("Hello World!!");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] Show �Լ� ȣ��
        Show();
    }
}

/*Function(�Լ�)// Method(�޼���)
: �ݺ��ؼ� ����ϵ��� ������� �ϳ� �̻��� ��ɹ����� ������ �ڵ���
-�����Լ�: ���(c#)���� �����ϴ� �Լ�, ����Ƽ���� �����ϴ� �Լ�
-������Լ�: �����ڰ� ����� �Լ�

-�ŰԺ����� ���� �Լ�:
-�Ű������� �ִ��Լ�
-��ȯ���� �ִ� �Լ�

void �Լ��̸�()
{
    //�ϳ� �̻��� ��ɹ�
    //......
}
void �Լ��̸�(�Ű�����)
{
    //�ϳ��̻��Ǹ�ɹ�
    //000
}
(������Ÿ��) �Լ��̸�()
{
    //�ϳ��̻��� ��ɹ�
    //....
    return ����(��);
}

//�Լ� ����
�Է� -> ó��(����) -> ���

//�Լ�(�޼���)
[1] �Լ� ����(��ɱ���)
[2] �Լ� ȣ��(��ɻ��)
*/

 
