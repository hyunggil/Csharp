using UnityEngine;

public class SwitchDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("���� ������ �������? (���� �帲 �� ��)");
        string weather = "�帲";

        switch(weather)
        {
            case "����":
                Debug.Log("���� ������ �����ϴ�.");
                break;

            case "�帲":
                Debug.Log("���� ������ �帲�ϴ�.");
                break;
            case "��":
                Debug.Log("���� ������ �� �����ϴ�.");
                break;
            default:
                Debug.Log("���� ������ ���� �����ϴ�.");
                break;
        }
    }

}
