using UnityEngine;
using System.Collections;
public class QueueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]Queue Ŭ������ �ν��Ͻ�(��ü,��ü) ����
        Queue queue = new Queue();
        //[2]ť�� ������ �Է� Enqueue
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        //[3] ť���� ������ ������ Dequeue - �ⱸ���� �� �տ� �ִ� �����͸� ������.
        Debug.Log($"{queue.Dequeue()},{queue.Count}");
        Debug.Log($"{queue.Dequeue()},{queue.Count}");
        Debug.Log($"{queue.Dequeue()},{queue.Count}");
    }
}

/*
Queue Ŭ����: FIFO(First in First out) ���·� �����͸� ���� �����ϴ� Ŭ����
FIFO(First in First out) : ���Լ���, ���� ���� ���� �����͸� ���� ���� ������.
�ͳ��� â�� ������ ����, ���ǥ

Enqueue(): ť���� ������ �ֱ�
Dequeue(): ť�� ������ ������
 */