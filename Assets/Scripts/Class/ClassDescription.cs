using UnityEngine;

public class ClassDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Run(); // ���� Ŭ������ �޼��� ȣ��
        ClassDescription.Run(); //.Ŭ���� ������ �޼��� ȣ��: Ŭ������ �̸�.�޼���() ȣ��
    }
    // ClassDescripti ��� Ŭ������ Run (����) �޼���
    static void Run()
    {
        Debug.Log("ClassDescripti ��� Ŭ������ Run �޼���");
    }
}
/*
class (Ŭ����) - c# �⺻�� �Ǵ� ����
: �ϳ��� �̸����� ���� �ٸ� ������ Ȥ�� ���� �ٸ� ������ ������ ��� �Լ����� ��� �����ϴ� �׸�(����)
: ...
:����� ���� ������ ����(������ ����� �ִ�.)

public class (Ŭ���� �̸�)
{

}
 */