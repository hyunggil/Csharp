using UnityEngine;
//�������� �����Ѵ� ������ ����
enum Animal
{
    Mouse,
    Cow,
    Tiger,
}
public class EnumAnimal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������ ���� �����ϰ� �ʱ�ȭ
        Animal animal = Animal.Tiger;
        Debug.Log(animal);

        //��� - ���ǹ����� ���ǽ�
        if(animal == Animal.Tiger)
        {
            Debug.Log("ȣ����");
        }
    }
}
