using UnityEngine;

public class Inttobite : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int�� ���� x�� �����ϰ� 255�� �ʱ�ȭ
        int x = 255;

        //byte�� ���� y�� ������ϰ� x�� ������ �ʱ�ȭ
        byte y = (byte)x;

        Debug.Log(x + "->" + y);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
