using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P13___ReversedList
{
    public  class RveresedList<T>:IEnumerable<T>
    {
        private T[] items;
        private int capacity;
        private int count;
        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }        

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public RveresedList(int capacity=2)
        {
            count = 0;
            Capacity = capacity;
            items = new T[capacity];
        }

        public void OutOfIndex(int index)
        {
            if (index < 0 && index>Count)
            { 
                throw new ArgumentOutOfRangeException("index");
            }
        }

        public void Add(T item)
        {
            
            if (Count == Capacity)
            {
                Capacity *= 2;
                T[] copy = new T[Capacity];
                for (int i = 0; i < Count; i++)
                {
                    copy[i] = items[i];
                }
                items = copy;
            }
            items[Count] = item;
            count++;
        }

        public T this[int index]
        {
            get
            {
                OutOfIndex(index);
                return items[index];
            }
            set
            {
                OutOfIndex(index);
                items[index] = value;
            }
        }



        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
