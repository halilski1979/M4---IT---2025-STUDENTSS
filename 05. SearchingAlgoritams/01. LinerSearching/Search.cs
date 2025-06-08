using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._LinerSearching
{
    public  class Search
    {
        public static int Linear<T>(T[]masiv, T key) where T : IComparable<T>
        {
            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i].CompareTo(key)==0)
                {
                    return i;
                }
                
            }
            return -1;
        }

        public int LinearSearch<T>(T[] masiv, T key) where T : IComparable<T>
        {
            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i].CompareTo(key) == 0)
                {
                    return i;
                }

            }
            return -1;
        }

        public bool LinearSearchElemennt<T>(T[] masiv, T key) where T : IComparable<T>
        {
            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i].CompareTo(key) == 0)
                {
                    return true;
                    break;
                }

            }
            return false;
        }


    }
}
