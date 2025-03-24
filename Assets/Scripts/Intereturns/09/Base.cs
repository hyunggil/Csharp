using UnityEngine;

namespace Override
{
    //부모클래스
    public class Base
    {
        public virtual void Work() => Debug.Log("부모가 말한다");

    }
    //자식클래스
    public class Sub : Base
    {
        //sealed 키워드를 통해서 재정의 금지
        
        public override sealed void Work()
        {
            Debug.Log("자식이 일한다");
        }
    }
    //손자클래스
    public class GrandSub : Sub
    {
        /*public override void Work()
        {
            Debug.Log("손자가 일한다");
        }*/
        public void Play() => Debug.Log("손자가 논다");
    }
}