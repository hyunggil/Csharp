using UnityEngine;
//�ȳ��ϼ��並 3�� ����ϴ� ���α׷�
public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�ʱ��
        int i = 0;
        do
        {
            //�ݺ� ���๮
            Debug.Log("�ȳ��ϼ���.");
            i++;
        } while (i < 3);    //���ǽ�
    //i:0 ->��� -> i:1 -> i<3 �� -> ��� -> i:2 -> i<3 ->�� ->��� ->i:3->i<3->���� ->dowhile�� ����
    }
}
/*
dowhile�� - �ݺ���
���� �ݺ� ���๮�� 1�� �����Ѵ�.
���ǽ��� true�̸� �ݺ����� �����Ѵ�
���ǽ��� false�� while���� �����Ѵ�.

do
{
    //�ݺ� ���๮
}
while(���ǽ�)
 */