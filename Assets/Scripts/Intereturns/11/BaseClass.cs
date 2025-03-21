using UnityEngine;

namespace Inheritance11
{
    //부모클래스
    public class BaseClass
    {
        //필드 - 기본적으로 private으로 설정
        private string word;

        //속성 - 상속받은 자식 클래스에서만 접근가능
        protected string Word
        {
            get { return word; }
            set { word = value; }
        }
    }

    //BaseClass클래스를 상속받는 자식클래스
    public class SubClass : BaseClass
    {
        public void SetWord(string _word)
        {
            base.Word = _word;
        }
        public string GetWord()
        {
            return base.Word;
        }
    }
}
