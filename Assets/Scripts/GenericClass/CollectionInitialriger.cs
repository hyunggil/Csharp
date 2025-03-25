using UnityEngine;
using System.Collections.Generic;
using System.Collections;
namespace GenericClass
{
    //고객을 관리하는 클래스
    public class Person
    {
        public string Name { get; set; }
    }
    public class CollectionInitialriger : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //고객전용 리스트
            List<Person> people = new List<Person>
            {
                new Person {Name = "홍길동"},
                new Person {Name = "백두산"},
                new Person {Name = "장길산"}
            };
            foreach (var p in people)
            {
                Debug.Log(p.Name);
            }
        }
    }
}