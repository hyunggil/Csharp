using UnityEngine;
//else ��ø��
public class ElseNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        char input = '1';
        //[1] input 'y' �̸� "yes" ���
        //[2] input 'n' �̸� "no" ���
        //[3] input �׿� ������ �̸� cancel ó��
        if(input == 'y')
        {
            Debug.Log("yes");
        }
        else
        {
            if(input == 'n')
            {
                Debug.Log("no");

            }
            else
            {
                Debug.Log("cancel");
            }
        }
    }
}
