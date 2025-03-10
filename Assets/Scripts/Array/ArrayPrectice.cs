using UnityEngine;

public class ArrayPrectice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[,] arr = new int[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                {
                    arr[i, j] = 0;
                }
                else
                {
                    arr[i, j] = 1;
                }

            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log($"arr[{i}, {j}]");
            }
        }
    }
}
/*
[q]
3��3���� 2���� �迭�� �����
�迭�� ���� �ʱ�ȭ �ϴµ� ��� ���� �ε����� ������ 1, ��� ���� �ε����� Ʋ���� 0���� �����ϼ���.
�����ϴ� ����� ���� for���� �̿��ϼ���.
1,0,0
0,1,0
0,0,1
 */