using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
//���� score�� 60 �� �̻��̸� "�հ�"�̶�� ����Ͻÿ�.
//score 61��
public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61;
        if(score >=60)  //���ǹ��� ���̸� ��Ͼȿ� �ִ� ���๮�� ����
        {
            Debug.Log("�հ�");
        }
    }
}
/*
if: ���ǹ�
���ǽ��� ���� ���� ���๮�� ����˴ϴ�.
���ǹ��� �����̸� ���๮�� ���� ���� �ʽ��ϴ�.
//���� ���ǽ��� ���̸� {} �ȿ� �ִ� ���๮�� �����϶�
if(bool)
{
    //���๮:
    //���๮2:
    //.....
}

 */