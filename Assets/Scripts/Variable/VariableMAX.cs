using UnityEngine;

public class VariableMAX : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 10;
        int second = 20;
        int third = 30;

        Debug.Log(first + ", " + second + ", " + third);

        Debug.Log("ù��°����" + first);
        Debug.Log("�ι�°����" + second);
        Debug.Log("����°����" + third);

        const int A = 100;

        Debug.Log(A);

    }

}
