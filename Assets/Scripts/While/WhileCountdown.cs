using UnityEngine;

public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 5;
        while(i > 0)
        {
            Debug.Log($"ī��Ʈ�ٿ�: {i}");
            i--;
        }
    }
}
