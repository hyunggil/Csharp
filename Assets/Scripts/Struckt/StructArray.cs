using UnityEngine;
//[1] ����ü ����, ����: ���� �����͸� �����ϴ� ����ü
struct UserInfo
{
    public string name;
    public int age;
    //......
}

public class StructArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]����ü ���� ����
        UserInfo info;
        //[2]�ʱ�ȭ
        info.name = "ȫ�浿";
        info.age = 20;
    
    }
    //���� ����� ����ϴ� �Լ�
    void PrintUserInfo(string name, int age)
    {
        Debug.Log($"{name}���� ���̴� {age}�� �Դϴ�.");
    }
}
