using UnityEngine;

public class ForIncripment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������
        //0���� 10���� ī���� �ϴµ� 2�� �����ϸ鼭 ����ϼ���.
        for(int i = 0; i < 11; i = i+2)
        {
            Debug.Log(i);
        }
    }

}
