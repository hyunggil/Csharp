using UnityEngine;
//������ : ������ �Ʒ��� ������� ��ɹ��� ����
public class SequensDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]���� ���� = �ʱ�ȭ
        int kor = 100;  //��������
        int eng = 90;   //��������

        int total = 0;  //����
        double avg = 0.0;   //�������
        //[2]������ �� ����
        total = kor + eng;  //�������ϱ�
        avg = total / 2.0;  //��ձ��ϱ�
        //[3] ���� ���
        Debug.Log($"����: {total} , ���: {avg}");
    }
}

/*
<���> : ���α׷��� �帧(����)�� ���ϴ� ����
-������ : ������ �Ʒ��� ������� ��ɹ��� ����
-���ǹ� : (if�� = else, switch) : ���ǿ� ���� ���� �ٸ� ��ɹ��� �����մϴ�.
-�ݺ���


*/