using UnityEngine;
//���� score�� 60�� �̻��̸�"�հ�" �̶�� ����ϰ�,
//�ƴϸ� "���հ�" �̶�� ���
//score 61��
public class ElseDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61; //[1]
        if(score >= 60)
        {
            Debug.Log("�հ�"); //[2]
        }
        else
        {
            Debug.Log("���հ�");   //[3]
        }
        Debug.Log("����");    //[4]
    }
}
