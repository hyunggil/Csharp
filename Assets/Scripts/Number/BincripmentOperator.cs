using UnityEngine;
//IncrementOperator (증가연산자)
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
