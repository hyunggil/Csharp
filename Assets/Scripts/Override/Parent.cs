using UnityEngine;

namespace Override
{
    //부모클래스
    public class Parent
    {
        public void Say() => Debug.Log("부모: 안녕하세요");
        public void Run() => Debug.Log("부모: 달린다");
        public virtual void Walk() => Debug.Log("부모: 걷다");
    }

    //자식클래스
    public class Child : Parent
    {
        public void Say() => Debug.Log("자식: 안녕하세요");
        public new void Run() => Debug.Log("자식: 달린다");
        public override void Walk() => Debug.Log("자식: 걷다");
    }
}