using System;
using System.Collections.Generic;

namespace Lab1
{
    public class Task1
    {
        public static bool prime(int x)
        {
            if (x == 1) return false;
            for (int i = 2; i <= x - 1; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        public static int[] filterPrimeNumbers(int[] n)
        {
            int sz = n.Length;
            List<int> p = new List<int>();
            int[] res;
            for (int i = 1; i < sz; i++)
            {
                int x = n[i];
                if (prime(x))
                {
                    p.Add(x);
                }
            }
            res = p.ToArray();
            return res;
        }
    }
    class Math
    {
        public static int kvadrat(int x)
        {
            return x * x;
        }
    }
}
