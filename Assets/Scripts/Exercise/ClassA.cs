using UnityEngine;
using UnityEngine.UI;
namespace Exer
{
    public class ClassA : MonoBehaviour
    {
        private string[] Names = new string[] { "일", "월", "화", "수", "목", "금", "토" };
        void Start()
        {
            PrintDays();
        }

        public void PrintDays()
        {
            for (int i = 0; i < Names.Length; i++)
            {
                Debug.Log(Names[i]);
            }

        }
    }
}