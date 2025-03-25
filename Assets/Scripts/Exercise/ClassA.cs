using UnityEngine;
using UnityEngine.UI;
namespace Exer
{
    public class ClassA : MonoBehaviour
    {
       
        void Start()
        {
            ClassC classC = new ClassC();

            classC.PrintDays();

            int result = ClassC.Add(5, 6);
            Debug.Log("결과: " + result);
        }


       
    }
}