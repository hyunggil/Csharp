using UnityEngine; // UnityEngine ���ӽ����̽��� ����Ͽ� Unity ���� ����� ���

public class MinValueFinder : MonoBehaviour // MonoBehaviour�� ��ӹ޾� Unity���� ����� �� �ִ� Ŭ����
{
    // Start �޼ҵ�� Unity���� �ش� ��ũ��Ʈ�� ����� �� ó�� ȣ���
    void Start()
    {
        // ���� �迭 ���� (5, 3, 6, 8, 9)
        int[] numbers = { 5, 3, 6, 8, 9 };

        // �迭�� �ּҰ��� ã�� ���� FindMinValue �޼ҵ带 ȣ���ϰ� ����� minValue ������ ����
        int minValue = FindMinValue(numbers);

        // �ּҰ��� Unity�� �ֿܼ� ���
        Debug.Log("�ּҰ���: " + minValue);
    }

    // �ּҰ��� ã�� �޼ҵ�
    int FindMinValue(int[] numbers)
    {
        // ù ��° ���� �⺻ �ּҰ����� ����
        int min = numbers[0];

        // �迭�� �� ���Ҹ� �ϳ��� ��
        foreach (int num in numbers)
        {
            // ���� ���� ��(num)�� ���� �ּҰ�(min)���� ������
            if (num < min)
            {
                // �ּҰ��� ���� ��(num)���� ����
                min = num;
            }
        }

        // �ּҰ��� ��ȯ
        return min;
    }
}
