using UnityEngine;
//4!���� ���ϴ� ���α׷�����
public class ForFactorial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int fact = 1;

        for(int i = 1; i <n+1; i++)
        {
            fact = fact * i;
        }
        Debug.Log($"4!�� {fact}��.");
    }

}
/*
Factorial(!)
1! = 1
2! = 1 * 2
3! = 1 * 2 * 3
4! = 1 * 2 * 3 * 4
.......
n! = 




 */