using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Stack<T> // 어댑터 패턴으로 스택 만들기
    {
        private List<T> list;

        public int Count { get { return list.Count; } } // 리스트 안의 개수를 Stack의 카운트로 반환
        
        public Stack() 
        { 
            list = new List<T>();
        }
        public void Push(T item)    // 리스트에 값 추가
        {
            list.Add(item);
        }
        public T Pop()      // 리스트의 마지막 값을 temp에 저장 후 값 삭제 그리고 temp 반환
        {
            T temp = list[Count-1];
            list.RemoveAt(Count - 1);
            return temp;
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}
