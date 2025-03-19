using UnityEngine;

namespace PrivatePublic
{
    public class StaticDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //PublicPrivate 클래스의 정적필드 사용, 정적 메서드 사용
            //클래스이름.필드이름 , 클래스이름.메서드이름
            PublicPrivate.name = "홍길등";
            //Debug.Log(PublicPrivate.name);
            string sName = PublicPrivate.GetName();
            Debug.Log(sName);

            //PublicPrivate의 객제 생성
            PublicPrivate publicPrivate = new PublicPrivate();
            //publicPrivate.age = 22;   //error
            //publicPrivate.SetAge(22);
            //int myAge = ublicPrivate(myAge);
            //Debug.Log()
        }
    }
}
