using UnityEngine;
// break;�� ���ѷ����� ���� ������
public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���ѷ��� -���ѹݺ�
        /*     for(; ;)
             {

             }*/
        /*  while(true)
          {

          }*/
        int number = 0;
        while (true)    //���ѷ���
        {
            //�ݺ����๮
            Debug.Log(number);
            number++;
            if(number >= 5)
            {
                break;
            }
        }
    }
}
