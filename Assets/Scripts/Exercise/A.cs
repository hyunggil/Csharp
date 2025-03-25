using System;
using UnityEngine;
public class A : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100;
        int j = 200;
        int temp;
        Debug.Log($"처음에는 i: {i} , j: {j}");
        temp = i;
        i = j;
        j = temp;
        Debug.Log($"변경후 i: {i} , j: {j}");
    }

}
