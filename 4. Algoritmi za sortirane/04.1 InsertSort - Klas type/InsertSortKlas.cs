using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._1_InsertSort___Klas_type
{
    public class InsertSortKlas <T> where T : IComparable<T>
    {
        public void InsertSort(T[] masiv) 

        {
            for (int i = 0; i < masiv.Length; i++)
            {
                int j = i;
                while (j > 0 && masiv[j - 1].CompareTo(masiv[j]) > 0)
                {
                    //Размяна на елементи
                    T temp = masiv[j - 1];
                    masiv[j - 1] = masiv[j];
                    masiv[j] = temp;

                    j--;
                }
            }
        }

        public void InsertSortDes(T[] masiv)

        {
            for (int i = 0; i < masiv.Length; i++)
            {
                int j = i;
                while (j > 0 && masiv[j - 1].CompareTo(masiv[j]) < 0)
                {
                    //Размяна на елементи
                    T temp = masiv[j - 1];
                    masiv[j - 1] = masiv[j];
                    masiv[j] = temp;

                    j--;
                }
            }
        }
    }
}
