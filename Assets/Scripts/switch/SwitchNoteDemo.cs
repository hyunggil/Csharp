using UnityEngine;

public class SwitchNoteDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 1;
        //switch: data���� ������ �Ǻ�
        switch(x)
        {
            case 1:
                Debug.Log("x�� 1�Դϴ�.");  //���๮1
                break;
            case 2:
                Debug.Log("x�� 2�Դϴ�.");  //���๮2
                break;
        }
        Debug.Log("���α׷� ����");
    }

}
/*
switch��: ���ǹ� - ����
switch(����) : Data �� �Ǻ�
{
    case 1��:
    //��ȷ��1
        break;
    case 2��:
        break;
    case 3��:
        break;

    defalt: //���case�� �ƴϸ�
        //���๮
        break;
}

 */