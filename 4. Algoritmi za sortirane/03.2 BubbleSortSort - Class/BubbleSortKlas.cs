using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._2_BubbleSortSort___Class
{
    public class BubbleSortKlas <T> where T : IComparable<T>
    {
        public void Sort(T[] masiv) 
        {
            for (int i = 0; i < masiv.Length - 1; i++)
            {
                for (int j = 0; j < masiv.Length - 1 - i; j++)
                {
                    if (masiv[j].CompareTo(masiv[j + 1]) > 0)
                    {
                        T temp = masiv[j];
                        masiv[j] = masiv[j + 1];
                        masiv[j + 1] = temp;
                    }
                }
            }
        }

        public void SortDescending(T[] masiv) 
        {
            for (int i = 0; i < masiv.Length - 1; i++)
            {
                for (int j = 0; j < masiv.Length - 1 - i; j++)
                {
                    if (masiv[j].CompareTo(masiv[j + 1]) > 0)
                    {
                        T temp = masiv[j];
                        masiv[j] = masiv[j + 1];
                        masiv[j + 1] = temp;
                    }
                }
            }
        }
    }
}
