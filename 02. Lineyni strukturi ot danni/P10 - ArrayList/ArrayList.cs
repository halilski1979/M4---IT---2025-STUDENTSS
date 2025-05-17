using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10___ArrayList
{
    public class ArrayList<T> : IEnumerable<T>
    {

        public int Count { get;private set; }
        private T[] items;
        public int Capacity { get;private set; }

        public ArrayList()
        {
            Capacity = 2;
            items=new T[Capacity];
            Count = 0;            
        }


        private void OutOfRange(int index)
        {
            if (index < 0 && index >= Count)
            {
                throw new ArgumentOutOfRangeException("index");
            }
        }


        //Метод за достъпване на елементите по индекс
        public T this[int index]
        {
            get
            {
                OutOfRange(index);
                return items[index];
            }
            set
            {
                OutOfRange(index);
                items[index] = value;
            }
        }


        //Увеличава капацитета
        public void Resize()
        {
            T[] copy = new T[items.Length*2];
            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }
            items= copy;
            Capacity = this.Capacity * 2;
        }

        public void Add(T item)
        {
            if(Count == Capacity)
            {
                Resize();
            }
            items[Count] = item;
            Count++;
        }

        //Метод за намаляване на капацитета на масива, ако е нужно
        private void Shrink()
        {
            T[]copy= new T[items.Length/2];
            for (int i = 0; i < items.Length; i++)
            {
                copy[i]=items[i];
            }
            items = copy;
        }

        //Метод за премахване на елементите с едно място наляво
        private void Shift(int index)
        {
            for (int i = index; i < Count-1; i++)
            {
                items[i] = items[i + 1];
            }
            items[Count - 1] = default(T);
        }


        public T RemoveAt(int index)
        {
            OutOfRange(index);
            T element= items[index];
            items[index]=default(T);

            Shift(index);
            Count--;

            if (Count <= items.Length / 4)
            {
                Shrink();
            }
            return element;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
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
