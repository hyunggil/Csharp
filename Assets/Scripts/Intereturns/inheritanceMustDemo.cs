using UnityEngine;

namespace Inheritance09
{
    public class inheritanceMustDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //person의 인스턴스 생성
            Person person = new Person();
            person.SayTalk();
        }
    }
}