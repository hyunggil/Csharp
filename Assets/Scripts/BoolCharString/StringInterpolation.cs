using UnityEngine;
//String Interpolation (������ ������)
public class StringInterpolation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string massage = "���ڿ� ������";

        Debug.Log("massage: " + massage);   //[1] ���ڿ� ���ϱ� ����
        Debug.Log($"massage: {massage}");   //[2] ���ڿ� ���������� ���

        //string.Format
        string msg = string.Format("{0}��, {1}", "ȫ�浿", "�ȳ��ϼ���");
        Debug.Log(msg);

    }

}
