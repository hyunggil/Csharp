using UnityEngine;
//���� �޼��� ȣ��, �ν��Ͻ� �޼��� ȣ��
public class MyFirstClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����(static)�޼��� ȣ��: Ŭ���� �̸�.�޼����̸�()StaticMethod()
        ClassMember.StaticMethod();

        //[2] �ν��Ͻ�(Instance)�޼��� ȣ��
        //ȣ����: 
        //Ŭ������ ��ü(��ü,instance) ���� (Ŭ������ ���� ����)
        //new Ű���带 �̿��Ͽ� ���ο� ��ü�� �����Ѵ�.
        //Ŭ�����̸� ��ü�̸� = new Ŭ�����̸�();
        //��ü�̸�.�޼����̸�()
        ClassMember member = new ClassMember();
        member.InstanceMethod();

    }
}
