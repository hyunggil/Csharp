using UnityEngine;
//�ȳ��ϼ��並 3�� ����ϴ� ���α׷�
public class WhileDiscription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*for(int i = 0; i < 3; i++)
        {
            Debug.Log("�ȳ��ϼ���.");
        }*/

        //[1] �ʱ��
        int i = 0;
        while(i < 3)    //���ǽ�
        {
            //�ݺ� ���๮
            Debug.Log("�ȳ��ϼ���");



            //������
            i++;
        }
        //int i = 0; -> ���ǽ� �Ǻ�(i:0) �� -> ��� -> ������(i:1) �� -> ��� -> ������(i:2) �� -> ��� ->������ (i:3) -> ���� ->while�� ����
    }

}
/*
while - �ݺ���
���ǽ��� true�̸� �ݺ����� �����Ѵ�.
���ǽ��� false�̸� while���� �����Ѵ�.
while(���ǽ�)
{
    //�ݺ� ���๮
    //���ǽĿ� ���� ���� ������
}
���ǽ� �Ǻ�(��) -> �ݺ��� ���� -> ���ǽ� �Ǻ�(��) ->�ݺ��� ���� ->���ǽ� �Ǻ�(����) ->while�� ����
 */