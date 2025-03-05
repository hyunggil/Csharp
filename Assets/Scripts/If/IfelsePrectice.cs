using UnityEngine;
//score가 90 이상이면 금메달출력, 80이상이면 은메달 출력, 70이상이면 동메달 출력, 그외 나머지는 노메달 출력
public class IfelsePrectice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;
        
            if (score >= 90)
            {
                Debug.Log("금메달을 수상하였습니다.");
            }
            else
            {
                if (score >= 80)
                {
                    Debug.Log("은메달을 수상하였습니다.");
                }
                else
                {
                    if (score >= 70)
                    {
                        Debug.Log("동메달을 수상하였습니다.");
                    }
                    else
                    {
                        Debug.Log("노메달을 수상하였습니다.");
                    }

                }
            }
        
    }
}
