using UnityEngine;
//���ڿ� ��
public class SpringConpare : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "Hello";
        string s2 = "Hello";
        // ���� s1 �� s2�� ������ same�̶�� ���
        if (s1 == s2) Debug.Log("same");

        //
        bool bln = false;
        //���� bln���� false�̸� ���๮�� ����
        if(bln == false)
        {
            Debug.Log("bln: " + bln);

            //!bln ���� ���̸� ���๮�� ����
            if (!bln == true)
            {
                Debug.Log("!bln: " + !bln);
            }
        }

    }

}
