using UnityEngine;
enum Animalw
{
    Chicken,
    Dog,
    Pig,
}
public class EnumAnimalDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������ ���� ���� �� �ʱ�ȭ
        Animalw ani = Animalw.Dog;
        PrintAnimal(ani);
    }
    void PrintAnimal(Animalw animal)
    {
       
    }
}
