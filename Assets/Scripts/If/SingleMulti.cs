using UnityEngine;
//���๮: �ܹ�(1��), ����(2�� �̻�)
public class SingleMulti : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���� ���ǽ��� ���̸�() �ȿ� �ִ� ���๮�� �����϶�
        /*
        fi(���ǽ�)
        {
        ���๮
        ���๮
        ....
        }

         */
        //�ܹ��� {} ���๮�� 1��
        if(1 == 1)
        {
            Debug.Log("�ܹ�");
        }
        if (1 == 1)
            Debug.Log("�ܹ�2");

        if (1 == 1) Debug.Log("�ܹ�3");

        //����
        if (1 == 1)
        {
            Debug.Log("����1");
            Debug.Log("����2");
        }

    }

}
/*
if()
{

}



 */