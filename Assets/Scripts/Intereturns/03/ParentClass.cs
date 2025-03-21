using System;
namespace Inheritance
{
    public class ParentClass : Object //Object가 생략되어있다.
    {
        public static void Hi() => UnityEngine.Debug.Log("안녕하세요");
    }
}