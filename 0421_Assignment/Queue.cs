using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Queue<T>
    {
        private const int DefaultSize = 10;
        private T[] list;
        private int head;
        private int tail;
        private int size;

        public int Count    // 배열의 원소 개수 반환
        { 
            get 
            { 
                return head > tail ? tail - head + size : tail - head;
            } 
        }

        public Queue()
        {
            list = new T[DefaultSize];
            head = 0;
            tail = 0;
            size = DefaultSize;
        }

        public void Enqueue(T item) // 배열이 꽉차 있다면 두배로 키우고 배열에 item 추가
        {
            if(IsFull())
            {
                Grow();
            }
            list[tail] = item;
            tail = (tail + 1) % size;
        }

        public T Dequeue()
        {
            if(Count == 0)        // 큐가 널이라면 에러
                throw new InvalidOperationException();
            T temp = list[head];        // haed의 값을 temp에 저장하고 head에 +1 배열의 size를 넘어간다면 0
            head = (head + 1) % size; 
            return temp;
        }

        private bool IsFull()       // queue가 가득찼는지 체크
        {
            return head == (tail + 1) % size;
        }

        public void Grow()
        {

            T[] newList = new T[size * 2];    // size를 두배로 해서 배열 생성
            int i = head;
            while(i%size != tail)   // head가 tail에 닿을 때 까지 배열 복사
            {
                newList[i] = list[i];
                i++;
            }
            tail = i;   
            size *= 2;
            list = newList;
        }
    }
}
