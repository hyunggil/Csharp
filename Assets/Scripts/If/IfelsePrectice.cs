using UnityEngine;
//score�� 90 �̻��̸� �ݸ޴����, 80�̻��̸� ���޴� ���, 70�̻��̸� ���޴� ���, �׿� �������� ��޴� ���
public class IfelsePrectice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;
        string medal = "";
        
            if (score >= 90)
            {
            medal = "�ݸ޴�";
            }
            else
            {
                if (score >= 80)
                {
                medal = "���޴�";
                }
                else
                {
                    if (score >= 70)
                    {
                    medal = "���޴�";
                    }
                    else
                    {
                    medal = "��޴�";
                    }

                }
            }
        Debug.Log($"{medal}�� �����Ͽ����ϴ�.");
        
    }
}
