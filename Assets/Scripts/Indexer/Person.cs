using UnityEngine;

namespace Indexer
{
    public class Person
    {
        //필드
        private string name;    //홍길동 저장

        //인덱서 : 인덱스 번호와 상관 없이 name 필드값을 읽도 쓰는것
        public string this[int index]
        {
            get { return name; }
            set { name = value; }
        }
    }
}