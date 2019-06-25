using System;
using System.Collections.Generic;

namespace Lab1
{
    public class Task3
    {
        public static int[] duplicateElements(int[] n)
        { 
            int[] b = new int[(n.Length * 2) + 1];
            for (int i = 0; i < n.Length; i++)
            {
                b[2 * i + 1] = n[i];
                b[2 * (i + 1)] = n[i];
                Console.WriteLine(i + " " + b[2 * i + 1] + " " + b[2 * (i + 1)]);
            }
            return b;
        }
    }
}
