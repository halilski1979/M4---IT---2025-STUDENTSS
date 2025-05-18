using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P12___ArrayStack
{
    public class ArrayStack<T> : IEnumerable<T>
    {
        private T[] elements;
        public int Count { get;private set; }
        private const int InitialCapacity = 2;
       
        public ArrayStack(int capacity = InitialCapacity) 
        {
          elements = new T[capacity];
            Count = 0;
        }

       
       
        //Увеличава капацитета на масива двойно
        public void Grow()
        {           
            T[]copy=new T[elements.Length*2];
            for (int i = 0; i < elements.Length; i++)
            {
                copy[i]=elements[i];
            }
            elements = copy;
        }

        //Намалява капацитета на масива двойно
        public void Shrink()
        {
            T[]copy=new T[elements.Length/2];
            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = elements[i];
            }
            elements = copy;
        }
        
        
        public void Push(T element)
        {
           if (elements.Length == Count)
            {
                Grow(); 
            }
           elements[Count] = element;
            Count++;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            
            if (Count <= elements.Length/2)
            {
                Shrink();
            }
            Count--;
            return elements[Count];
        }

        public T[] ConvertToMasiv()
        {
            return elements.ToArray();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
