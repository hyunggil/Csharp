using UnityEngine;

public class ForCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       /* for(int i = 5; i > 0; i--)
        {
            Debug.Log($"���� countdown: {i}");
        }*/
       for(int i = 0; i < 6; i++)
        {
            Debug.Log($"���� countdown: {(5 - i)}");
        }
    }

}
