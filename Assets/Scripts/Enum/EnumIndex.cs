using UnityEngine;
//������ ���� �������̳� ���ڿ��� ����� ����
enum Animals
{
    Rabbit,
    Dragon,
    Snake,
}
public class EnumIndex : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������ ���� ���� �� �ʱ�ȭ
        Animals animal = Animals.Dragon;
        int num = (int)animal;
        string str = animal.ToString();
        Debug.Log($"animals.Dragon: {num},{str}");
    }
}
