using UnityEngine;

public class ifElseAlll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�ϳ��� ������ �Է¹޾Ƽ� ¦������ Ȧ������ �Ǻ�
        int number = 21;
        //¦���Ǻ�
        if (number % 2 == 0)
        {
            Debug.Log($"{number}�� ¦��");
        }
        if(number % 2 != 0) //Ȧ�� �Ǻ�
        {
            Debug.Log($"{number}�� Ȧ�� �Դϴ�.");
        }
        else
        {
            Debug.Log($"{number}�� ¦�� �Դϴ�.");
        }
        if (number % 3 == 0)
        {
            Debug.Log($"{number}�� 3�� ���");
        }
        else if (number % 5 == 0)
        {
            Debug.Log($"{number}�� 5�� ���");
        }
        if(number % 7 == 0)
        {
            Debug.Log($"{number}�� 7�� ���");
        }
    }

}
