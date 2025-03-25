using UnityEngine;

namespace Exer
{
    public class ClassC
    {
        private string[] Names = new string[] { "일", "월", "화", "수", "목", "금", "토" };
        public void PrintDays()
        {
            for (int i = 0; i < Names.Length; i++)
            {
                Debug.Log(Names[i]);
            }

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}