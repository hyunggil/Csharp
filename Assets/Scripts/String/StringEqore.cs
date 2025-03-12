using UnityEngine;
//문자열 비교하기 - 2가지 방법
public class StringEqore : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string userName = "RedPlus";
        string inputName = "redPlus";
        //[1]연산자 더블이콜(==)연산자 사용하여 비교
        if (userName.ToLower() == inputName.ToLower()) ;
        {
            Debug.Log("[1]같습니다.");
        }
        //[2] string.Equal()메서드 사용.
        if (string.Equals(userName, inputName, System.StringComparison.InvariantCultureIgnoreCase));
        {
            Debug.Log("[2]같습니다.");
        }
    }
}
