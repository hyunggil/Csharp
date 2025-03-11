using UnityEngine;
//동물들을 구분한느 열거형 새성
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
        //열거형 변수 선언하고 초기화
        Animal animal = Animal.Tiger;
        Debug.Log(animal);

        //사용 - 조건문에서 조건식
        if(animal == Animal.Tiger)
        {
            Debug.Log("호랑이");
        }
    }
}
