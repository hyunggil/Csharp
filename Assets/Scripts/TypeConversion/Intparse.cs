using UnityEngine;

public class Intparse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string strnumber = "1234";

        int number1 = System.Convert.ToInt32(strnumber);
        Debug.Log($"{number1} - {number1.GetType()}");

    }
}
