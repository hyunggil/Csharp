using UnityEngine;

public class ConstanceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //����
        string name = "ȫ�浿";
        name = "�̼���";
        //���
        const int AGE = 20; //������ ���
        //AGE = 21; ���� �Ұ���
        //����, ��� ���
        Debug.Log($"{name} + {AGE}");


        
    }

}
