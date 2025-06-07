using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._SlectionSort___Class
{
    public class SelectionSort<T> where T :IComparable<T>
    {
        public void SortAscending(T[]masiv)
        {
            for (int i = 0; i < masiv.Length; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < masiv.Length; j++)
                {
                    if (masiv[j].CompareTo(masiv[minIndex])<0)
                    {
                        minIndex = j;
                    }
                }

                //Разменяме текущият с минималният елемент
                if (minIndex!=i)
                {
                    T temp = masiv[i];
                    masiv[i] = masiv[minIndex];
                    masiv[minIndex] = temp;

                }

            }
        }



        public void SortDescending(T[] masiv)
        {
            for (int i = 0; i < masiv.Length; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < masiv.Length; j++)
                {
                    if (masiv[j].CompareTo(masiv[maxIndex]) > 0)
                    {
                        maxIndex = j;
                    }
                }

                //Разменяме текущият с минималният елемент
                if (maxIndex != i)
                {
                    T temp = masiv[i];
                    masiv[i] = masiv[maxIndex];
                    masiv[maxIndex] = temp;

                }

            }
        }

    }
}
