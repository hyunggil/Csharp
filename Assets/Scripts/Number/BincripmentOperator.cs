using UnityEngine;
//IncrementOperator (����������)
public class BincripmentOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 100;
        //num += 1;
        ++num;  //101
        Debug.Log("num: " + num);
    }
}
