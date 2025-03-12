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
        //열거형 변수 선언 및 초기화
        Animalw ani = Animalw.Dog;
        PrintAnimal(ani);
    }
    void PrintAnimal(Animalw animal)
    {
       
    }
}
