
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;
namespace PrivatePublic
{
    public class FieldArray : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Schedule 클래스의 인스턴스(객체)생성
            Scadule scadule = new Scadule();
            scadule.PrintWeekDays();
        }
    }
}
