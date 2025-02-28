using UnityEngine; // UnityEngine 네임스페이스를 사용하여 Unity 관련 기능을 사용

public class MinValueFinder : MonoBehaviour // MonoBehaviour를 상속받아 Unity에서 사용할 수 있는 클래스
{
    // Start 메소드는 Unity에서 해당 스크립트가 실행될 때 처음 호출됨
    void Start()
    {
        // 숫자 배열 선언 (5, 3, 6, 8, 9)
        int[] numbers = { 5, 3, 6, 8, 9 };

        // 배열의 최소값을 찾기 위해 FindMinValue 메소드를 호출하고 결과를 minValue 변수에 저장
        int minValue = FindMinValue(numbers);

        // 최소값을 Unity의 콘솔에 출력
        Debug.Log("최소값은: " + minValue);
    }

    // 최소값을 찾는 메소드
    int FindMinValue(int[] numbers)
    {
        // 첫 번째 값을 기본 최소값으로 설정
        int min = numbers[0];

        // 배열의 각 원소를 하나씩 비교
        foreach (int num in numbers)
        {
            // 만약 현재 값(num)이 기존 최소값(min)보다 작으면
            if (num < min)
            {
                // 최소값을 현재 값(num)으로 갱신
                min = num;
            }
        }

        // 최소값을 반환
        return min;
    }
}
