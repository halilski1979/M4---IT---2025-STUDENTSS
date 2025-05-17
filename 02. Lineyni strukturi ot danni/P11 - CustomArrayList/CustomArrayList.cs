using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___CustomArrayList
{
    public class CustomArrayList
    {

		private const int initialCapacity = 4;
		private object[] arr;
		private int count;
        private int capacity;

        public int Count
		{
			get { return count; }
			set { count = value; }
		}		

		public int Capacity
		{
			get { return capacity; }
			set { capacity = value; }
		}

		public CustomArrayList(int size=initialCapacity)
		{
			arr = new object[size];
			Capacity = size;
			count = 0;
		}

		private void OutOfIndex(int index)
		{
			if (index < 0 && index >= count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
		}

		private object this[int index]
		{
			get
			{
				OutOfIndex(index);
				return arr[index];
			}
			set
			{
				OutOfIndex(index);
				arr[index] = value;
				count++;
			}
		}
        public object Get(int index)
        {
            OutOfIndex(index);
            return arr[index];
        }

        public void Add(object item)
		{
			if (capacity == count)
			{
				capacity *= 2;
				object[] copy = arr;
				arr = new object[capacity];

				for (int i = 0; i < copy.Length; i++)
				{
					arr[i] = copy[i];
				}
				arr[count] = item;
			}
			else
			{
				arr[count] = item;
			}
			count++;
		}


		public object Remove(int index)
		{
			OutOfIndex(index);
			var elementForDelete = arr[index];

            for (int i = index; i <count-1; i++)
            {
				arr[i] = arr[i + 1];
            }
			arr[count - 1] = null;
			count--;

			return elementForDelete;
        }

		public void Insert(int index, object item)
		{
			OutOfIndex(index);
			object[] copy = new object[count+1];
            
			//I стъпка
			for (int i = 0; i < index; i++)
            {
				copy[i] = arr[i];
            }

			//II стъпка
			copy[index]= item;

            //III стъпка
            for (int i = index; i < count; i++)
            {
				copy[i + 1] = arr[i];
            }

			arr=copy;
			count++;
        }

		public void Clear()
		{
			arr = new object[capacity];
		}

		//Метод за итерация през елементите на CustomArray
		public IEnumerator<object> GetEnumerator()
		{
            for (int i = 0; i < count; i++)
            {
				yield return arr[i];
            }
        }

	}
}
