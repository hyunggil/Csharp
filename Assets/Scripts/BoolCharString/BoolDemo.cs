using UnityEngine;
// bool (��) : ����, ���ڷ���, ��(true), ����(false) ���� �����Ѵ�.
public class BoolDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bool ���� �����ϰ� �ʱ�ȭ
        bool bin = true;

        Debug.Log("bin: " + bin);

        bool isOut = false;

        Debug.Log("isOut: " + isOut);

    }

}
